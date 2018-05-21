function [TrainingTime, TrainingAccuracy] = OSELM_train(TrainingData_File, Elm_Type, nHiddenNeurons, ActivationFunction, N0, Block)

% Sample1 regression: OSELM_train('Train', 0, 25, 'rbf', 75, 1);
% Sample2 classification: OSELM_train('Train', 1, 55, 'sig', 110, 20);

%%%%%%%%%%% Macro definition
REGRESSION=0; 
CLASSIFICATION=1;

%%%%%%%%%%% Load dataset
train_data=load(TrainingData_File);
T=train_data(:,1); P=train_data(:,2:size(train_data,2));

clear train_data;

nTrainingData=size(P,1); 
nInputNeurons=size(P,2);

%%%%%%%%%%%% Preprocessing T in the case of CLASSIFICATION 
if Elm_Type==CLASSIFICATION
    
    sorted_target=sort(cat(1,T),1);
    label=zeros(1,1);                               %   Find and save in 'label' class label from training and testing data sets
    label(1,1)=sorted_target(1,1);
    j=1;
    for i = 2:nTrainingData
        if sorted_target(i,1) ~= label(j,1)
            j=j+1;
            label(j,1) = sorted_target(i,1);
        end
    end
    nClass=j;
    nOutputNeurons=nClass;
    
    %%%%%%%%%% Processing the targets of training
    temp_T=zeros(nTrainingData,nClass);
    for i = 1:nTrainingData
        for j = 1:nClass
            if label(j,1) == T(i,1)
                break; 
            end
        end
        temp_T(i,j)=1;
    end
    T=temp_T*2-1;
end
    
start_time_train=cputime;
%%%%%%%%%%% step 1 Initialization Phase
P0=P(1:N0,:); 
T0=T(1:N0,:);

IW = rand(nHiddenNeurons,nInputNeurons)*2-1;
switch lower(ActivationFunction)
    case{'rbf'}
        Bias = rand(1,nHiddenNeurons);
%        Bias = rand(1,nHiddenNeurons)*1/3+1/11;     %%%%%%%%%%%%% for the cases of Image Segment and Satellite Image
%        Bias = rand(1,nHiddenNeurons)*1/20+1/60;    %%%%%%%%%%%%% for the case of DNA
        H0 = RBFun(P0,IW,Bias);
    case{'sig'}
        Bias = rand(1,nHiddenNeurons)*2-1;
        H0 = SigActFun(P0,IW,Bias);
    case{'sin'}
        Bias = rand(1,nHiddenNeurons)*2-1;
        H0 = SinActFun(P0,IW,Bias);
    case{'hardlim'}
        Bias = rand(1,nHiddenNeurons)*2-1;
        H0 = HardlimActFun(P0,IW,Bias);
        H0 = double(H0);
end

M = pinv(H0' * H0);
OW = pinv(H0) * T0;
clear P0 T0 H0;

%%%%%%%%%%%%% step 2 Sequential Learning Phase
for n = N0 : Block : nTrainingData
    if (n+Block-1) > nTrainingData
        Pn = P(n:nTrainingData,:);    Tn = T(n:nTrainingData,:);
        Block = size(Pn,1);             %%%% correct the block size
        clear V;                        %%%% correct the first dimention of V 
    else
        Pn = P(n:(n+Block-1),:);    Tn = T(n:(n+Block-1),:);
    end
    
    switch lower(ActivationFunction)
        case{'rbf'}
            H = RBFun(Pn,IW,Bias);
        case{'sig'}
            H = SigActFun(Pn,IW,Bias);
        case{'sin'}
            H = SinActFun(Pn,IW,Bias);
        case{'hardlim'}
            H = HardlimActFun(Pn,IW,Bias);
    end    
    M = M - M * H' * (eye(Block) + H * M * H')^(-1) * H * M; 
    OW = OW + M * H' * (Tn - H * OW);
end
end_time_train=cputime;
TrainingTime=end_time_train-start_time_train        
clear Pn Tn H M;

switch lower(ActivationFunction)
    case{'rbf'}
        HTrain = RBFun(P, IW, Bias);
    case{'sig'}
        HTrain = SigActFun(P, IW, Bias);
    case{'sin'}
        HTrain = SinActFun(P, IW, Bias);
    case{'hardlim'}
        HTrain = HardlimActFun(P, IW, Bias);
end
Y=HTrain * OW;
clear HTrain;

if Elm_Type == REGRESSION
    %%%%%%%%%%%%%% Calculate RMSE in the case of REGRESSION
    TrainingAccuracy=sqrt(mse(T - Y))         
elseif Elm_Type == CLASSIFICATION
%%%%%%%%%% Calculate correct classification rate in the case of CLASSIFICATION
    MissClassificationRate_Training=0;

    for i = 1 : nTrainingData
        [x, label_index_expected]=max(T(i,:));
        [x, label_index_actual]=max(Y(i,:));
        if label_index_actual~=label_index_expected
            MissClassificationRate_Training=MissClassificationRate_Training+1;
        end
    end
    TrainingAccuracy=1-MissClassificationRate_Training/nTrainingData
end

if Elm_Type~=REGRESSION
    clear save;
    save('OSELM_model', 'nInputNeurons', 'nOutputNeurons', 'IW', 'Bias', 'OW', 'ActivationFunction', 'label', 'Elm_Type');
	
    %Data = load('OSELM_model.mat');
     %DataField = fieldnames(Data);
     %dlmwrite('DataTrain_IW.txt', Data.(DataField{6}));
     %dlmwrite('DataTrain_Bias.txt', Data.(DataField{7}));
     %dlmwrite('DataTrain_OW.txt', Data.(DataField{8}));
else
    save('OSELM_model', 'IW', 'Bias', 'OW', 'ActivationFunction', 'Elm_Type');
    %Data = load('OSELM_model.mat');
    %DataField = fieldnames(Data);
    %dlmwrite('OSELM_model.txt', Data.(DataField{1}));
end