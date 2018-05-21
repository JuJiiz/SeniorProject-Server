function [PredictResult, TestingAccuracy] = OSELM_predict(hog_class,hog_values)
test_data = reshape(str2num(hog_values), 1, []);

TV.T=hog_class; TV.P=test_data(:,1:size(test_data,2));

clear test_data;                                    %   Release raw testing data array

nTestingData=size(TV.P,1);

load OSELM_model.mat;

    %%%%%%%%%% Processing the targets of testing
    temp_TV_T=zeros(nTestingData,nOutputNeurons);
    
    for i = 1:nTestingData
        for j = 1:nOutputNeurons
            if label(j,1) == TV.T(i,1)
                break; 
            end
        end
        temp_TV_T(i,j)=1;
    end
    TV.T=temp_TV_T*2-1;

V=TV.P*IW'; ind=ones(1,size(TV.P,1));
BiasMatrix=Bias(ind,:);      
V=V+BiasMatrix;
HTest = 1./(1+exp(-V));
  
TY=HTest*OW;

%%%%%%%%%% Calculate correct classification rate in the case of CLASSIFICATION
MissClassificationRate_Testing=0;

    for i = 1 : nTestingData
        [x, label_index_expected]=max(TV.T(i,:));
        [x, label_index_actual]=max(TY(i,:));
        output(i)=label(label_index_actual);
        if label_index_actual~=label_index_expected
            MissClassificationRate_Testing=MissClassificationRate_Testing+1;
        end
    end
    
TestingAccuracy=1-MissClassificationRate_Testing/nTestingData;  
PredictResult = output;
% save('OSELM_output','output');
% Data = load('OSELM_output.mat');
%      DataField = fieldnames(Data);
%      dlmwrite('Predict_output.txt', Data.(DataField{1}));