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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public AsrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public AsrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口服务对录音时长1小时以内的录音文件进行识别，异步返回识别全部结果。
        /// <br>• 支持回调或轮询的方式获取结果，轮询方式请参考“录音文件识别结果查询”。
        /// <br>• 支持语音 URL 和本地语音文件两种请求方式。
        /// <br>• 接口是 HTTP RESTful 形式
        /// 
        /// 在使用该接口前，需要在 [语音识别控制台](https://console.cloud.tencent.com/asr) 开通服务，并进入 [API 密钥管理页面](https://console.cloud.tencent.com/cam/capi) 新建密钥，<br>生成 AppID、SecretID 和 SecretKey ，用于 API 调用时生成签名，签名将用来进行接口鉴权。
        /// </summary>
        /// <param name="req">参考<see cref="CreateRecTaskRequest"/></param>
        /// <returns>参考<see cref="CreateRecTaskResponse"/>实例</returns>
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
        /// 本接口需要配合录音文件识别请求接口使用，单独使用无效。在调用录音文件识别接口后，可以在本接口传入TaskID来轮询识别结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskStatusResponse"/>实例</returns>
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
        /// 本接口用于对60秒之内的短音频文件进行识别。
        /// <br>•   支持中文普通话、英语、粤语和带有一定方言口音的中文普通话识别。
        /// <br>•   支持本地语音文件上传和语音URL上传两种请求方式。
        /// <br>•   音频格式支持wav、mp3；采样率支持8000Hz或者16000Hz；采样精度支持16bits；声道支持单声道。
        /// <br>•   当音频文件通过请求中body内容上传时，请求大小不能超过600KB；当音频以URL方式传输时，音频时长不可超过60s。
        /// <br>•   所有请求参数放在POST请求的body中，编码类型采用x-www-form-urlencoded，参数进行urlencode编码后传输。
        /// </summary>
        /// <param name="req">参考<see cref="SentenceRecognitionRequest"/></param>
        /// <returns>参考<see cref="SentenceRecognitionResponse"/>实例</returns>
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

    }
}
