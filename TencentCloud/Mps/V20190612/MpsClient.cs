/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mps.V20190612
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mps.V20190612.Models;

   public class MpsClient : AbstractClient{

       private const string endpoint = "mps.tencentcloudapi.com";
       private const string version = "2019-06-12";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public MpsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public MpsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建用户自定义内容识别模板，数量上限：50。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateAIRecognitionTemplateResponse"/>实例</returns>
        public async Task<CreateAIRecognitionTemplateResponse> CreateAIRecognitionTemplate(CreateAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<CreateAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义转动图模板，数量上限：16。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateAnimatedGraphicsTemplateResponse"/>实例</returns>
        public async Task<CreateAnimatedGraphicsTemplateResponse> CreateAnimatedGraphicsTemplate(CreateAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<CreateAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义内容审核模板，数量上限：50。
        /// </summary>
        /// <param name="req">参考<see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateContentReviewTemplateResponse"/>实例</returns>
        public async Task<CreateContentReviewTemplateResponse> CreateContentReviewTemplate(CreateContentReviewTemplateRequest req)
        {
             JsonResponseModel<CreateContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义雪碧图模板，数量上限：16。
        /// </summary>
        /// <param name="req">参考<see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateImageSpriteTemplateResponse"/>实例</returns>
        public async Task<CreateImageSpriteTemplateResponse> CreateImageSpriteTemplate(CreateImageSpriteTemplateRequest req)
        {
             JsonResponseModel<CreateImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于创建人物样本，用于通过人脸识别等技术，进行内容识别、内容审核等视频处理。
        /// </summary>
        /// <param name="req">参考<see cref="CreatePersonSampleRequest"/></param>
        /// <returns>参考<see cref="CreatePersonSampleResponse"/>实例</returns>
        public async Task<CreatePersonSampleResponse> CreatePersonSample(CreatePersonSampleRequest req)
        {
             JsonResponseModel<CreatePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义采样截图模板，数量上限：16。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateSampleSnapshotTemplateResponse"/>实例</returns>
        public async Task<CreateSampleSnapshotTemplateResponse> CreateSampleSnapshotTemplate(CreateSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义指定时间点截图模板，数量上限：16。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateSnapshotByTimeOffsetTemplateResponse"/>实例</returns>
        public async Task<CreateSnapshotByTimeOffsetTemplateResponse> CreateSnapshotByTimeOffsetTemplate(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义转码模板，数量上限：1000。
        /// </summary>
        /// <param name="req">参考<see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateTranscodeTemplateResponse"/>实例</returns>
        public async Task<CreateTranscodeTemplateResponse> CreateTranscodeTemplate(CreateTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义水印模板，数量上限：1000。
        /// </summary>
        /// <param name="req">参考<see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateWatermarkTemplateResponse"/>实例</returns>
        public async Task<CreateWatermarkTemplateResponse> CreateWatermarkTemplate(CreateWatermarkTemplateRequest req)
        {
             JsonResponseModel<CreateWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量创建关键词样本，样本用于通过OCR、ASR技术，进行内容审核、内容识别等视频处理。
        /// </summary>
        /// <param name="req">参考<see cref="CreateWordSamplesRequest"/></param>
        /// <returns>参考<see cref="CreateWordSamplesResponse"/>实例</returns>
        public async Task<CreateWordSamplesResponse> CreateWordSamples(CreateWordSamplesRequest req)
        {
             JsonResponseModel<CreateWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对 COS 中指定 Bucket 的目录下上传的媒体文件，设置处理规则，包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、鉴恐、鉴政）；
        /// 8. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词）。
        /// 
        /// 注意：创建工作流成功后是禁用状态，需要手动启用。
        /// </summary>
        /// <param name="req">参考<see cref="CreateWorkflowRequest"/></param>
        /// <returns>参考<see cref="CreateWorkflowResponse"/>实例</returns>
        public async Task<CreateWorkflowResponse> CreateWorkflow(CreateWorkflowRequest req)
        {
             JsonResponseModel<CreateWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义内容识别模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteAIRecognitionTemplateResponse"/>实例</returns>
        public async Task<DeleteAIRecognitionTemplateResponse> DeleteAIRecognitionTemplate(DeleteAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<DeleteAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义转动图模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteAnimatedGraphicsTemplateResponse"/>实例</returns>
        public async Task<DeleteAnimatedGraphicsTemplateResponse> DeleteAnimatedGraphicsTemplate(DeleteAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义内容审核模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteContentReviewTemplateResponse"/>实例</returns>
        public async Task<DeleteContentReviewTemplateResponse> DeleteContentReviewTemplate(DeleteContentReviewTemplateRequest req)
        {
             JsonResponseModel<DeleteContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除雪碧图模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteImageSpriteTemplateResponse"/>实例</returns>
        public async Task<DeleteImageSpriteTemplateResponse> DeleteImageSpriteTemplate(DeleteImageSpriteTemplateRequest req)
        {
             JsonResponseModel<DeleteImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据人物 ID，删除人物样本。
        /// </summary>
        /// <param name="req">参考<see cref="DeletePersonSampleRequest"/></param>
        /// <returns>参考<see cref="DeletePersonSampleResponse"/>实例</returns>
        public async Task<DeletePersonSampleResponse> DeletePersonSample(DeletePersonSampleRequest req)
        {
             JsonResponseModel<DeletePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义采样截图模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteSampleSnapshotTemplateResponse"/>实例</returns>
        public async Task<DeleteSampleSnapshotTemplateResponse> DeleteSampleSnapshotTemplate(DeleteSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/>实例</returns>
        public async Task<DeleteSnapshotByTimeOffsetTemplateResponse> DeleteSnapshotByTimeOffsetTemplate(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义转码模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteTranscodeTemplateResponse"/>实例</returns>
        public async Task<DeleteTranscodeTemplateResponse> DeleteTranscodeTemplate(DeleteTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义水印模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteWatermarkTemplateResponse"/>实例</returns>
        public async Task<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest req)
        {
             JsonResponseModel<DeleteWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量删除关键词样本。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteWordSamplesRequest"/></param>
        /// <returns>参考<see cref="DeleteWordSamplesResponse"/>实例</returns>
        public async Task<DeleteWordSamplesResponse> DeleteWordSamples(DeleteWordSamplesRequest req)
        {
             JsonResponseModel<DeleteWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除工作流。对于已启用的工作流，需要禁用后才能删除。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteWorkflowRequest"/></param>
        /// <returns>参考<see cref="DeleteWorkflowResponse"/>实例</returns>
        public async Task<DeleteWorkflowResponse> DeleteWorkflow(DeleteWorkflowRequest req)
        {
             JsonResponseModel<DeleteWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据内容识别模板唯一标识，获取内容识别模板详情列表。返回结果包含符合条件的所有用户自定义内容识别模板及系统预置视频内容识别模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeAIRecognitionTemplatesResponse"/>实例</returns>
        public async Task<DescribeAIRecognitionTemplatesResponse> DescribeAIRecognitionTemplates(DescribeAIRecognitionTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIRecognitionTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAIRecognitionTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIRecognitionTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转动图模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeAnimatedGraphicsTemplatesResponse"/>实例</returns>
        public async Task<DescribeAnimatedGraphicsTemplatesResponse> DescribeAnimatedGraphicsTemplates(DescribeAnimatedGraphicsTemplatesRequest req)
        {
             JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAnimatedGraphicsTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据内容审核模板唯一标识，获取内容审核模板详情列表。返回结果包含符合条件的所有用户自定义模板及系统预置内容审核模板。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeContentReviewTemplatesResponse"/>实例</returns>
        public async Task<DescribeContentReviewTemplatesResponse> DescribeContentReviewTemplates(DescribeContentReviewTemplatesRequest req)
        {
             JsonResponseModel<DescribeContentReviewTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContentReviewTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentReviewTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询雪碧图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeImageSpriteTemplatesResponse"/>实例</returns>
        public async Task<DescribeImageSpriteTemplatesResponse> DescribeImageSpriteTemplates(DescribeImageSpriteTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageSpriteTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageSpriteTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSpriteTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询人物样本信息，支持根据人物 ID、名称、标签，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonSamplesRequest"/></param>
        /// <returns>参考<see cref="DescribePersonSamplesResponse"/>实例</returns>
        public async Task<DescribePersonSamplesResponse> DescribePersonSamples(DescribePersonSamplesRequest req)
        {
             JsonResponseModel<DescribePersonSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询采样截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeSampleSnapshotTemplatesResponse"/>实例</returns>
        public async Task<DescribeSampleSnapshotTemplatesResponse> DescribeSampleSnapshotTemplates(DescribeSampleSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeSampleSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSampleSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间点截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/>实例</returns>
        public async Task<DescribeSnapshotByTimeOffsetTemplatesResponse> DescribeSnapshotByTimeOffsetTemplates(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
             JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotByTimeOffsetTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过任务 ID 查询任务的执行状态和结果的详细信息（最多可以查询3天之内提交的任务）。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskDetailResponse"/>实例</returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 该接口用于查询任务列表；
        /// * 当列表数据比较多时，单次接口调用无法拉取整个列表，可通过 ScrollToken 参数，分批拉取；
        /// * 只能查询到最近三天（72 小时）内的任务。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTasksRequest"/></param>
        /// <returns>参考<see cref="DescribeTasksResponse"/>实例</returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据转码模板唯一标识，获取转码模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置转码模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeTranscodeTemplatesResponse"/>实例</returns>
        public async Task<DescribeTranscodeTemplatesResponse> DescribeTranscodeTemplates(DescribeTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户自定义水印模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeWatermarkTemplatesResponse"/>实例</returns>
        public async Task<DescribeWatermarkTemplatesResponse> DescribeWatermarkTemplates(DescribeWatermarkTemplatesRequest req)
        {
             JsonResponseModel<DescribeWatermarkTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWatermarkTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWatermarkTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据应用场景、关键词、标签，分页查询关键词样本信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWordSamplesRequest"/></param>
        /// <returns>参考<see cref="DescribeWordSamplesResponse"/>实例</returns>
        public async Task<DescribeWordSamplesResponse> DescribeWordSamples(DescribeWordSamplesRequest req)
        {
             JsonResponseModel<DescribeWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据工作流 ID，获取工作流详情列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWorkflowsRequest"/></param>
        /// <returns>参考<see cref="DescribeWorkflowsResponse"/>实例</returns>
        public async Task<DescribeWorkflowsResponse> DescribeWorkflows(DescribeWorkflowsRequest req)
        {
             JsonResponseModel<DescribeWorkflowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkflows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkflowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用工作流。
        /// </summary>
        /// <param name="req">参考<see cref="DisableWorkflowRequest"/></param>
        /// <returns>参考<see cref="DisableWorkflowResponse"/>实例</returns>
        public async Task<DisableWorkflowResponse> DisableWorkflow(DisableWorkflowRequest req)
        {
             JsonResponseModel<DisableWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用工作流。
        /// </summary>
        /// <param name="req">参考<see cref="EnableWorkflowRequest"/></param>
        /// <returns>参考<see cref="EnableWorkflowResponse"/>实例</returns>
        public async Task<EnableWorkflowResponse> EnableWorkflow(EnableWorkflowRequest req)
        {
             JsonResponseModel<EnableWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义内容识别模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyAIRecognitionTemplateResponse"/>实例</returns>
        public async Task<ModifyAIRecognitionTemplateResponse> ModifyAIRecognitionTemplate(ModifyAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<ModifyAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义转动图模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyAnimatedGraphicsTemplateResponse"/>实例</returns>
        public async Task<ModifyAnimatedGraphicsTemplateResponse> ModifyAnimatedGraphicsTemplate(ModifyAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义内容审核模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyContentReviewTemplateResponse"/>实例</returns>
        public async Task<ModifyContentReviewTemplateResponse> ModifyContentReviewTemplate(ModifyContentReviewTemplateRequest req)
        {
             JsonResponseModel<ModifyContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义雪碧图模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyImageSpriteTemplateResponse"/>实例</returns>
        public async Task<ModifyImageSpriteTemplateResponse> ModifyImageSpriteTemplate(ModifyImageSpriteTemplateRequest req)
        {
             JsonResponseModel<ModifyImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据人物 ID，修改人物样本信息，包括名称、描述的修改，以及人脸、标签的添加、删除、重置操作。人脸删除操作需保证至少剩余 1 张图片，否则，请使用重置操作。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonSampleRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonSampleResponse"/>实例</returns>
        public async Task<ModifyPersonSampleResponse> ModifyPersonSample(ModifyPersonSampleRequest req)
        {
             JsonResponseModel<ModifyPersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义采样截图模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifySampleSnapshotTemplateResponse"/>实例</returns>
        public async Task<ModifySampleSnapshotTemplateResponse> ModifySampleSnapshotTemplate(ModifySampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifySampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifySnapshotByTimeOffsetTemplateResponse"/>实例</returns>
        public async Task<ModifySnapshotByTimeOffsetTemplateResponse> ModifySnapshotByTimeOffsetTemplate(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义转码模板信息。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyTranscodeTemplateResponse"/>实例</returns>
        public async Task<ModifyTranscodeTemplateResponse> ModifyTranscodeTemplate(ModifyTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义水印模板，水印类型不允许修改。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyWatermarkTemplateResponse"/>实例</returns>
        public async Task<ModifyWatermarkTemplateResponse> ModifyWatermarkTemplate(ModifyWatermarkTemplateRequest req)
        {
             JsonResponseModel<ModifyWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改关键词的应用场景、标签，关键词本身不可修改，如需修改，可删除重建。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyWordSampleRequest"/></param>
        /// <returns>参考<see cref="ModifyWordSampleResponse"/>实例</returns>
        public async Task<ModifyWordSampleResponse> ModifyWordSample(ModifyWordSampleRequest req)
        {
             JsonResponseModel<ModifyWordSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWordSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWordSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从 CMQ 获取到消息后，从消息的 msgBody 字段中解析出 MPS 直播流处理事件通知的内容。
        /// 该接口不用于发起网络调用，而是用来帮助生成各个语言平台的 SDK，您可以参考 SDK 的中解析函数的实现事件通知的解析。
        /// </summary>
        /// <param name="req">参考<see cref="ParseLiveStreamProcessNotificationRequest"/></param>
        /// <returns>参考<see cref="ParseLiveStreamProcessNotificationResponse"/>实例</returns>
        public async Task<ParseLiveStreamProcessNotificationResponse> ParseLiveStreamProcessNotification(ParseLiveStreamProcessNotificationRequest req)
        {
             JsonResponseModel<ParseLiveStreamProcessNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ParseLiveStreamProcessNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseLiveStreamProcessNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从 CMQ 获取到消息后，从消息的 msgBody 字段中解析出 MPS 事件通知的内容。
        /// 该接口不用于发起网络调用，而是用来帮助生成各个语言平台的 SDK，您可以参考 SDK 的中解析函数的实现事件通知的解析。
        /// </summary>
        /// <param name="req">参考<see cref="ParseNotificationRequest"/></param>
        /// <returns>参考<see cref="ParseNotificationResponse"/>实例</returns>
        public async Task<ParseNotificationResponse> ParseNotification(ParseNotificationRequest req)
        {
             JsonResponseModel<ParseNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ParseNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对直播流媒体发起处理任务，功能包括：
        /// 
        /// * 智能内容审核（画面鉴黄、鉴政、鉴暴、声音鉴黄）。
        /// 
        /// 直播流处理事件通知实时写入用户指定的消息队列 CMQ 中，用户需要从消息队列 CMQ 中获取事件通知结果，同时处理过程中存在输出文件的，会写入用户指定的输出文件的目标存储中。
        /// </summary>
        /// <param name="req">参考<see cref="ProcessLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ProcessLiveStreamResponse"/>实例</returns>
        public async Task<ProcessLiveStreamResponse> ProcessLiveStream(ProcessLiveStreamRequest req)
        {
             JsonResponseModel<ProcessLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ProcessLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对 COS 中的媒体文件发起处理任务，功能包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、鉴恐、鉴政）；
        /// 8. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词）。
        /// </summary>
        /// <param name="req">参考<see cref="ProcessMediaRequest"/></param>
        /// <returns>参考<see cref="ProcessMediaResponse"/>实例</returns>
        public async Task<ProcessMediaResponse> ProcessMedia(ProcessMediaRequest req)
        {
             JsonResponseModel<ProcessMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ProcessMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新设置一个已经存在且处于禁用状态的工作流。
        /// </summary>
        /// <param name="req">参考<see cref="ResetWorkflowRequest"/></param>
        /// <returns>参考<see cref="ResetWorkflowResponse"/>实例</returns>
        public async Task<ResetWorkflowResponse> ResetWorkflow(ResetWorkflowRequest req)
        {
             JsonResponseModel<ResetWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
