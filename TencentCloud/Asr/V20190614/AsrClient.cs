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

namespace TencentCloud.Asr.V20190614
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Asr.V20190614.Models;

   public class AsrClient : AbstractClient{

       private const string endpoint = "asr.tencentcloudapi.com";
       private const string version = "2019-06-14";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AsrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AsrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用户通过本接口进行热词表的创建。
        /// <br>•   默认最多可创建30个热词表。
        /// <br>•   每个热词表最多可添加128个词，每个词最长10个字，不能超出限制。
        /// <br>•   热词表可以通过数组或者本地文件形式上传。
        /// <br>•   本地文件必须为UTF-8编码格式，每行仅添加一个热词且不能包含标点和特殊字符。
        /// <br>•   热词权重取值范围为[1,10]之间的整数，权重越大代表该词被识别出来的概率越大。
        /// </summary>
        /// <param name="req"><see cref="CreateAsrVocabRequest"/></param>
        /// <returns><see cref="CreateAsrVocabResponse"/></returns>
        public async Task<CreateAsrVocabResponse> CreateAsrVocab(CreateAsrVocabRequest req)
        {
             JsonResponseModel<CreateAsrVocabResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAsrVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAsrVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口进行热词表的创建。
        /// <br>•   默认最多可创建30个热词表。
        /// <br>•   每个热词表最多可添加128个词，每个词最长10个字，不能超出限制。
        /// <br>•   热词表可以通过数组或者本地文件形式上传。
        /// <br>•   本地文件必须为UTF-8编码格式，每行仅添加一个热词且不能包含标点和特殊字符。
        /// <br>•   热词权重取值范围为[1,10]之间的整数，权重越大代表该词被识别出来的概率越大。
        /// </summary>
        /// <param name="req"><see cref="CreateAsrVocabRequest"/></param>
        /// <returns><see cref="CreateAsrVocabResponse"/></returns>
        public CreateAsrVocabResponse CreateAsrVocabSync(CreateAsrVocabRequest req)
        {
             JsonResponseModel<CreateAsrVocabResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAsrVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAsrVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口服务对时长5小时以内的录音文件进行识别，异步返回识别全部结果， HTTP RESTful 形式。
        /// <br>• 支持中文普通话、英语、粤语和日语
        /// <br>• 支持通用、音视频领域
        /// <br>• 支持wav、mp3、m4a的音频格式
        /// <br>• 支持语音 URL 和本地语音文件两种请求方式
        /// <br>• 语音 URL 的音频时长不能长于5小时，文件大小不超过512MB
        /// <br>• 本地语音文件不能大于5MB
        /// <br>• 支持回调或轮询的方式获取结果，结果获取请参考[ 录音文件识别结果查询](https://cloud.tencent.com/document/product/1093/37822)。
        /// </summary>
        /// <param name="req"><see cref="CreateRecTaskRequest"/></param>
        /// <returns><see cref="CreateRecTaskResponse"/></returns>
        public async Task<CreateRecTaskResponse> CreateRecTask(CreateRecTaskRequest req)
        {
             JsonResponseModel<CreateRecTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRecTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口服务对时长5小时以内的录音文件进行识别，异步返回识别全部结果， HTTP RESTful 形式。
        /// <br>• 支持中文普通话、英语、粤语和日语
        /// <br>• 支持通用、音视频领域
        /// <br>• 支持wav、mp3、m4a的音频格式
        /// <br>• 支持语音 URL 和本地语音文件两种请求方式
        /// <br>• 语音 URL 的音频时长不能长于5小时，文件大小不超过512MB
        /// <br>• 本地语音文件不能大于5MB
        /// <br>• 支持回调或轮询的方式获取结果，结果获取请参考[ 录音文件识别结果查询](https://cloud.tencent.com/document/product/1093/37822)。
        /// </summary>
        /// <param name="req"><see cref="CreateRecTaskRequest"/></param>
        /// <returns><see cref="CreateRecTaskResponse"/></returns>
        public CreateRecTaskResponse CreateRecTaskSync(CreateRecTaskRequest req)
        {
             JsonResponseModel<CreateRecTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRecTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口进行热词表的删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAsrVocabRequest"/></param>
        /// <returns><see cref="DeleteAsrVocabResponse"/></returns>
        public async Task<DeleteAsrVocabResponse> DeleteAsrVocab(DeleteAsrVocabRequest req)
        {
             JsonResponseModel<DeleteAsrVocabResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAsrVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAsrVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口进行热词表的删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAsrVocabRequest"/></param>
        /// <returns><see cref="DeleteAsrVocabResponse"/></returns>
        public DeleteAsrVocabResponse DeleteAsrVocabSync(DeleteAsrVocabRequest req)
        {
             JsonResponseModel<DeleteAsrVocabResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAsrVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAsrVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在调用录音文件识别请求接口后，有回调和轮询两种方式获取识别结果。
        /// <br>• 当采用回调方式时，识别完成后会将结果通过 POST 请求的形式通知到用户在请求时填写的回调 URL，具体请参见[ 录音识别结果回调 ](https://cloud.tencent.com/document/product/1093/37139#callback)。
        /// <br>• 当采用轮询方式时，需要主动提交任务ID来轮询识别结果，共有任务成功、等待、执行中和失败四种结果，具体信息请参见下文说明。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public async Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在调用录音文件识别请求接口后，有回调和轮询两种方式获取识别结果。
        /// <br>• 当采用回调方式时，识别完成后会将结果通过 POST 请求的形式通知到用户在请求时填写的回调 URL，具体请参见[ 录音识别结果回调 ](https://cloud.tencent.com/document/product/1093/37139#callback)。
        /// <br>• 当采用轮询方式时，需要主动提交任务ID来轮询识别结果，共有任务成功、等待、执行中和失败四种结果，具体信息请参见下文说明。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口进行热词表的下载，获得词表权重文件形式的 base64 值，文件形式为通过 “|” 分割的词和权重，即 word|weight 的形式。
        /// </summary>
        /// <param name="req"><see cref="DownloadAsrVocabRequest"/></param>
        /// <returns><see cref="DownloadAsrVocabResponse"/></returns>
        public async Task<DownloadAsrVocabResponse> DownloadAsrVocab(DownloadAsrVocabRequest req)
        {
             JsonResponseModel<DownloadAsrVocabResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadAsrVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadAsrVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口进行热词表的下载，获得词表权重文件形式的 base64 值，文件形式为通过 “|” 分割的词和权重，即 word|weight 的形式。
        /// </summary>
        /// <param name="req"><see cref="DownloadAsrVocabRequest"/></param>
        /// <returns><see cref="DownloadAsrVocabResponse"/></returns>
        public DownloadAsrVocabResponse DownloadAsrVocabSync(DownloadAsrVocabRequest req)
        {
             JsonResponseModel<DownloadAsrVocabResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadAsrVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadAsrVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户根据词表的ID可以获取对应的热词表信息
        /// </summary>
        /// <param name="req"><see cref="GetAsrVocabRequest"/></param>
        /// <returns><see cref="GetAsrVocabResponse"/></returns>
        public async Task<GetAsrVocabResponse> GetAsrVocab(GetAsrVocabRequest req)
        {
             JsonResponseModel<GetAsrVocabResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAsrVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAsrVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户根据词表的ID可以获取对应的热词表信息
        /// </summary>
        /// <param name="req"><see cref="GetAsrVocabRequest"/></param>
        /// <returns><see cref="GetAsrVocabResponse"/></returns>
        public GetAsrVocabResponse GetAsrVocabSync(GetAsrVocabRequest req)
        {
             JsonResponseModel<GetAsrVocabResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAsrVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAsrVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口，可获得所有的热词表及其信息。
        /// </summary>
        /// <param name="req"><see cref="GetAsrVocabListRequest"/></param>
        /// <returns><see cref="GetAsrVocabListResponse"/></returns>
        public async Task<GetAsrVocabListResponse> GetAsrVocabList(GetAsrVocabListRequest req)
        {
             JsonResponseModel<GetAsrVocabListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAsrVocabList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAsrVocabListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口，可获得所有的热词表及其信息。
        /// </summary>
        /// <param name="req"><see cref="GetAsrVocabListRequest"/></param>
        /// <returns><see cref="GetAsrVocabListResponse"/></returns>
        public GetAsrVocabListResponse GetAsrVocabListSync(GetAsrVocabListRequest req)
        {
             JsonResponseModel<GetAsrVocabListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAsrVocabList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAsrVocabListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于对60秒之内的短音频文件进行识别。
        /// <br>•   支持中文普通话、英语、粤语、日语。
        /// <br>•   支持本地语音文件上传和语音URL上传两种请求方式，音频时长不能超过60s。
        /// <br>•   音频格式支持wav、mp3；采样率支持8000Hz或者16000Hz；采样精度支持16bits；声道支持单声道。
        /// <br>•   当音频文件通过请求中body内容上传时，请求大小不能超过3MB。
        /// <br>•   所有请求参数放在POST请求的body中，编码类型采用x-www-form-urlencoded，参数进行urlencode编码后传输。
        /// </summary>
        /// <param name="req"><see cref="SentenceRecognitionRequest"/></param>
        /// <returns><see cref="SentenceRecognitionResponse"/></returns>
        public async Task<SentenceRecognitionResponse> SentenceRecognition(SentenceRecognitionRequest req)
        {
             JsonResponseModel<SentenceRecognitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SentenceRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SentenceRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于对60秒之内的短音频文件进行识别。
        /// <br>•   支持中文普通话、英语、粤语、日语。
        /// <br>•   支持本地语音文件上传和语音URL上传两种请求方式，音频时长不能超过60s。
        /// <br>•   音频格式支持wav、mp3；采样率支持8000Hz或者16000Hz；采样精度支持16bits；声道支持单声道。
        /// <br>•   当音频文件通过请求中body内容上传时，请求大小不能超过3MB。
        /// <br>•   所有请求参数放在POST请求的body中，编码类型采用x-www-form-urlencoded，参数进行urlencode编码后传输。
        /// </summary>
        /// <param name="req"><see cref="SentenceRecognitionRequest"/></param>
        /// <returns><see cref="SentenceRecognitionResponse"/></returns>
        public SentenceRecognitionResponse SentenceRecognitionSync(SentenceRecognitionRequest req)
        {
             JsonResponseModel<SentenceRecognitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SentenceRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SentenceRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口可以设置热词表的默认状态。初始状态为0，用户可设置状态为1，即为默认状态。默认状态表示用户在请求识别时，如不设置热词表ID，则默认使用状态为1的热词表。
        /// </summary>
        /// <param name="req"><see cref="SetVocabStateRequest"/></param>
        /// <returns><see cref="SetVocabStateResponse"/></returns>
        public async Task<SetVocabStateResponse> SetVocabState(SetVocabStateRequest req)
        {
             JsonResponseModel<SetVocabStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetVocabState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVocabStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口可以设置热词表的默认状态。初始状态为0，用户可设置状态为1，即为默认状态。默认状态表示用户在请求识别时，如不设置热词表ID，则默认使用状态为1的热词表。
        /// </summary>
        /// <param name="req"><see cref="SetVocabStateRequest"/></param>
        /// <returns><see cref="SetVocabStateResponse"/></returns>
        public SetVocabStateResponse SetVocabStateSync(SetVocabStateRequest req)
        {
             JsonResponseModel<SetVocabStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetVocabState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVocabStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口进行对应的词表信息更新。
        /// </summary>
        /// <param name="req"><see cref="UpdateAsrVocabRequest"/></param>
        /// <returns><see cref="UpdateAsrVocabResponse"/></returns>
        public async Task<UpdateAsrVocabResponse> UpdateAsrVocab(UpdateAsrVocabRequest req)
        {
             JsonResponseModel<UpdateAsrVocabResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAsrVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAsrVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口进行对应的词表信息更新。
        /// </summary>
        /// <param name="req"><see cref="UpdateAsrVocabRequest"/></param>
        /// <returns><see cref="UpdateAsrVocabResponse"/></returns>
        public UpdateAsrVocabResponse UpdateAsrVocabSync(UpdateAsrVocabRequest req)
        {
             JsonResponseModel<UpdateAsrVocabResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAsrVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAsrVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
