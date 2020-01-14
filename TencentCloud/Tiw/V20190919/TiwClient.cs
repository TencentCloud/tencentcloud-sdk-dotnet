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

namespace TencentCloud.Tiw.V20190919
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tiw.V20190919.Models;

   public class TiwClient : AbstractClient{

       private const string endpoint = "tiw.tencentcloudapi.com";
       private const string version = "2019-09-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TiwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TiwClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建一个文档转码任务
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeRequest"/></param>
        /// <returns><see cref="CreateTranscodeResponse"/></returns>
        public async Task<CreateTranscodeResponse> CreateTranscode(CreateTranscodeRequest req)
        {
             JsonResponseModel<CreateTranscodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateTranscode接口的同步版本，创建一个文档转码任务
        /// </summary>
        /// <param name="req">参考<see cref="CreateTranscodeRequest"/></param>
        /// <returns>参考<see cref="CreateTranscodeResponse"/>实例</returns>
        public CreateTranscodeResponse CreateTranscodeSync(CreateTranscodeRequest req)
        {
             JsonResponseModel<CreateTranscodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实时录制任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordResponse"/></returns>
        public async Task<DescribeOnlineRecordResponse> DescribeOnlineRecord(DescribeOnlineRecordRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeOnlineRecord接口的同步版本，查询实时录制任务状态与结果
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOnlineRecordRequest"/></param>
        /// <returns>参考<see cref="DescribeOnlineRecordResponse"/>实例</returns>
        public DescribeOnlineRecordResponse DescribeOnlineRecordSync(DescribeOnlineRecordRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实时录制回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordCallbackResponse"/></returns>
        public async Task<DescribeOnlineRecordCallbackResponse> DescribeOnlineRecordCallback(DescribeOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeOnlineRecordCallback接口的同步版本，查询实时录制回调地址
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOnlineRecordCallbackRequest"/></param>
        /// <returns>参考<see cref="DescribeOnlineRecordCallbackResponse"/>实例</returns>
        public DescribeOnlineRecordCallbackResponse DescribeOnlineRecordCallbackSync(DescribeOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文档转码任务的执行进度与转码结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeRequest"/></param>
        /// <returns><see cref="DescribeTranscodeResponse"/></returns>
        public async Task<DescribeTranscodeResponse> DescribeTranscode(DescribeTranscodeRequest req)
        {
             JsonResponseModel<DescribeTranscodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTranscode接口的同步版本，查询文档转码任务的执行进度与转码结果
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTranscodeRequest"/></param>
        /// <returns>参考<see cref="DescribeTranscodeResponse"/>实例</returns>
        public DescribeTranscodeResponse DescribeTranscodeSync(DescribeTranscodeRequest req)
        {
             JsonResponseModel<DescribeTranscodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文档转码回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeCallbackRequest"/></param>
        /// <returns><see cref="DescribeTranscodeCallbackResponse"/></returns>
        public async Task<DescribeTranscodeCallbackResponse> DescribeTranscodeCallback(DescribeTranscodeCallbackRequest req)
        {
             JsonResponseModel<DescribeTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTranscodeCallback接口的同步版本，查询文档转码回调地址
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTranscodeCallbackRequest"/></param>
        /// <returns>参考<see cref="DescribeTranscodeCallbackResponse"/>实例</returns>
        public DescribeTranscodeCallbackResponse DescribeTranscodeCallbackSync(DescribeTranscodeCallbackRequest req)
        {
             JsonResponseModel<DescribeTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停实时录制
        /// </summary>
        /// <param name="req"><see cref="PauseOnlineRecordRequest"/></param>
        /// <returns><see cref="PauseOnlineRecordResponse"/></returns>
        public async Task<PauseOnlineRecordResponse> PauseOnlineRecord(PauseOnlineRecordRequest req)
        {
             JsonResponseModel<PauseOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PauseOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PauseOnlineRecord接口的同步版本，暂停实时录制
        /// </summary>
        /// <param name="req">参考<see cref="PauseOnlineRecordRequest"/></param>
        /// <returns>参考<see cref="PauseOnlineRecordResponse"/>实例</returns>
        public PauseOnlineRecordResponse PauseOnlineRecordSync(PauseOnlineRecordRequest req)
        {
             JsonResponseModel<PauseOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PauseOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复实时录制
        /// </summary>
        /// <param name="req"><see cref="ResumeOnlineRecordRequest"/></param>
        /// <returns><see cref="ResumeOnlineRecordResponse"/></returns>
        public async Task<ResumeOnlineRecordResponse> ResumeOnlineRecord(ResumeOnlineRecordRequest req)
        {
             JsonResponseModel<ResumeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResumeOnlineRecord接口的同步版本，恢复实时录制
        /// </summary>
        /// <param name="req">参考<see cref="ResumeOnlineRecordRequest"/></param>
        /// <returns>参考<see cref="ResumeOnlineRecordResponse"/>实例</returns>
        public ResumeOnlineRecordResponse ResumeOnlineRecordSync(ResumeOnlineRecordRequest req)
        {
             JsonResponseModel<ResumeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置实时录制回调地址
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackResponse"/></returns>
        public async Task<SetOnlineRecordCallbackResponse> SetOnlineRecordCallback(SetOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<SetOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetOnlineRecordCallback接口的同步版本，设置实时录制回调地址
        /// </summary>
        /// <param name="req">参考<see cref="SetOnlineRecordCallbackRequest"/></param>
        /// <returns>参考<see cref="SetOnlineRecordCallbackResponse"/>实例</returns>
        public SetOnlineRecordCallbackResponse SetOnlineRecordCallbackSync(SetOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<SetOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置文档转码回调地址
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackResponse"/></returns>
        public async Task<SetTranscodeCallbackResponse> SetTranscodeCallback(SetTranscodeCallbackRequest req)
        {
             JsonResponseModel<SetTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetTranscodeCallback接口的同步版本，设置文档转码回调地址
        /// </summary>
        /// <param name="req">参考<see cref="SetTranscodeCallbackRequest"/></param>
        /// <returns>参考<see cref="SetTranscodeCallbackResponse"/>实例</returns>
        public SetTranscodeCallbackResponse SetTranscodeCallbackSync(SetTranscodeCallbackRequest req)
        {
             JsonResponseModel<SetTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起一个实时录制任务
        /// </summary>
        /// <param name="req"><see cref="StartOnlineRecordRequest"/></param>
        /// <returns><see cref="StartOnlineRecordResponse"/></returns>
        public async Task<StartOnlineRecordResponse> StartOnlineRecord(StartOnlineRecordRequest req)
        {
             JsonResponseModel<StartOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartOnlineRecord接口的同步版本，发起一个实时录制任务
        /// </summary>
        /// <param name="req">参考<see cref="StartOnlineRecordRequest"/></param>
        /// <returns>参考<see cref="StartOnlineRecordResponse"/>实例</returns>
        public StartOnlineRecordResponse StartOnlineRecordSync(StartOnlineRecordRequest req)
        {
             JsonResponseModel<StartOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止实时录制
        /// </summary>
        /// <param name="req"><see cref="StopOnlineRecordRequest"/></param>
        /// <returns><see cref="StopOnlineRecordResponse"/></returns>
        public async Task<StopOnlineRecordResponse> StopOnlineRecord(StopOnlineRecordRequest req)
        {
             JsonResponseModel<StopOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StopOnlineRecord接口的同步版本，停止实时录制
        /// </summary>
        /// <param name="req">参考<see cref="StopOnlineRecordRequest"/></param>
        /// <returns>参考<see cref="StopOnlineRecordResponse"/>实例</returns>
        public StopOnlineRecordResponse StopOnlineRecordSync(StopOnlineRecordRequest req)
        {
             JsonResponseModel<StopOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
