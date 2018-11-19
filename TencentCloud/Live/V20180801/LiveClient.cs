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

namespace TencentCloud.Live.V20180801
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Live.V20180801.Models;

   public class LiveClient : AbstractClient{

       private const string endpoint = "live.tencentcloudapi.com";
       private const string version = "2018-08-01";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public LiveClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public LiveClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 对流设置延播
        /// </summary>
        /// <param name="req">参考<see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns>参考<see cref="AddDelayLiveStreamResponse"/>实例</returns>
        public async Task<AddDelayLiveStreamResponse> AddDelayLiveStream(AddDelayLiveStreamRequest req)
        {
             JsonResponseModel<AddDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加水印
        /// </summary>
        /// <param name="req">参考<see cref="AddLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="AddLiveWatermarkResponse"/>实例</returns>
        public async Task<AddLiveWatermarkResponse> AddLiveWatermark(AddLiveWatermarkRequest req)
        {
             JsonResponseModel<AddLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// - 使用前提
        ///   1. 录制文件存放于点播平台，所以用户如需使用录制功能，需首先自行开通点播服务。
        ///   2. 录制文件存放后相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，具体请参考 [对应文档](https://cloud.tencent.com/document/product/266/2838)。
        /// 
        /// - 模式说明
        ///   该接口支持两种录制模式：
        ///   1. 定时录制模式。
        ///     需要传入开始时间与结束时间，录制任务根据时间自动开始与结束。
        ///   2. 实时视频录制模式。
        ///     忽略传入的开始时间，在录制任务创建后立即开始录制，录制时长支持最大为30分钟，如果传入的结束时间与当前时间差大于30分钟，则按30分钟计算，实时视频录制主要用于录制精彩视频场景，时长建议控制在5分钟以内。
        /// 
        /// - 注意事项
        ///   1. 调用接口超时设置应大于3秒，小于3秒重试以及频繁调用都有可能产生重复录制任务。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveRecordRequest"/></param>
        /// <returns>参考<see cref="CreateLiveRecordResponse"/>实例</returns>
        public async Task<CreateLiveRecordResponse> CreateLiveRecord(CreateLiveRecordRequest req)
        {
             JsonResponseModel<CreateLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加拉流配置
        /// </summary>
        /// <param name="req">参考<see cref="CreatePullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="CreatePullStreamConfigResponse"/>实例</returns>
        public async Task<CreatePullStreamConfigResponse> CreatePullStreamConfig(CreatePullStreamConfigRequest req)
        {
             JsonResponseModel<CreatePullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除录制任务
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveRecordRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveRecordResponse"/>实例</returns>
        public async Task<DeleteLiveRecordResponse> DeleteLiveRecord(DeleteLiveRecordRequest req)
        {
             JsonResponseModel<DeleteLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除水印
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveWatermarkResponse"/>实例</returns>
        public async Task<DeleteLiveWatermarkResponse> DeleteLiveWatermark(DeleteLiveWatermarkRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询播放鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeLivePlayAuthKeyResponse"/>实例</returns>
        public async Task<DescribeLivePlayAuthKeyResponse> DescribeLivePlayAuthKey(DescribeLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询直播推流鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeLivePushAuthKeyResponse"/>实例</returns>
        public async Task<DescribeLivePushAuthKeyResponse> DescribeLivePushAuthKey(DescribeLivePushAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询在线推流信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamOnlineInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamOnlineInfoResponse"/>实例</returns>
        public async Task<DescribeLiveStreamOnlineInfoResponse> DescribeLiveStreamOnlineInfo(DescribeLiveStreamOnlineInfoRequest req)
        {
             JsonResponseModel<DescribeLiveStreamOnlineInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamOnlineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamOnlineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回正在直播中的流列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamOnlineListResponse"/>实例</returns>
        public async Task<DescribeLiveStreamOnlineListResponse> DescribeLiveStreamOnlineList(DescribeLiveStreamOnlineListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamOnlineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamOnlineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamOnlineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回已经推过流的流列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamPublishedListResponse"/>实例</returns>
        public async Task<DescribeLiveStreamPublishedListResponse> DescribeLiveStreamPublishedList(DescribeLiveStreamPublishedListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamPublishedListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamPublishedList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamPublishedListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回直播中、无推流或者禁播等状态
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamStateResponse"/>实例</returns>
        public async Task<DescribeLiveStreamStateResponse> DescribeLiveStreamState(DescribeLiveStreamStateRequest req)
        {
             JsonResponseModel<DescribeLiveStreamStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询水印列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveWatermarksResponse"/>实例</returns>
        public async Task<DescribeLiveWatermarksResponse> DescribeLiveWatermarks(DescribeLiveWatermarksRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveWatermarks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拉流配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribePullStreamConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribePullStreamConfigsResponse"/>实例</returns>
        public async Task<DescribePullStreamConfigsResponse> DescribePullStreamConfigs(DescribePullStreamConfigsRequest req)
        {
             JsonResponseModel<DescribePullStreamConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePullStreamConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePullStreamConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 断开推流连接，但可以重新推流
        /// </summary>
        /// <param name="req">参考<see cref="DropLiveStreamRequest"/></param>
        /// <returns>参考<see cref="DropLiveStreamResponse"/>实例</returns>
        public async Task<DropLiveStreamResponse> DropLiveStream(DropLiveStreamRequest req)
        {
             JsonResponseModel<DropLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DropLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复。
        /// </summary>
        /// <param name="req">参考<see cref="ForbidLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ForbidLiveStreamResponse"/>实例</returns>
        public async Task<ForbidLiveStreamResponse> ForbidLiveStream(ForbidLiveStreamRequest req)
        {
             JsonResponseModel<ForbidLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForbidLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改播放鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns>参考<see cref="ModifyLivePlayAuthKeyResponse"/>实例</returns>
        public async Task<ModifyLivePlayAuthKeyResponse> ModifyLivePlayAuthKey(ModifyLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改直播推流鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns>参考<see cref="ModifyLivePushAuthKeyResponse"/>实例</returns>
        public async Task<ModifyLivePushAuthKeyResponse> ModifyLivePushAuthKey(ModifyLivePushAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新拉流配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="ModifyPullStreamConfigResponse"/>实例</returns>
        public async Task<ModifyPullStreamConfigResponse> ModifyPullStreamConfig(ModifyPullStreamConfigRequest req)
        {
             JsonResponseModel<ModifyPullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改直播拉流配置状态
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPullStreamStatusRequest"/></param>
        /// <returns>参考<see cref="ModifyPullStreamStatusResponse"/>实例</returns>
        public async Task<ModifyPullStreamStatusResponse> ModifyPullStreamStatus(ModifyPullStreamStatusRequest req)
        {
             JsonResponseModel<ModifyPullStreamStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPullStreamStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPullStreamStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复延迟播放设置
        /// </summary>
        /// <param name="req">参考<see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ResumeDelayLiveStreamResponse"/>实例</returns>
        public async Task<ResumeDelayLiveStreamResponse> ResumeDelayLiveStream(ResumeDelayLiveStreamRequest req)
        {
             JsonResponseModel<ResumeDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复某条流的推送。
        /// </summary>
        /// <param name="req">参考<see cref="ResumeLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ResumeLiveStreamResponse"/>实例</returns>
        public async Task<ResumeLiveStreamResponse> ResumeLiveStream(ResumeLiveStreamRequest req)
        {
             JsonResponseModel<ResumeLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置水印是否启用
        /// </summary>
        /// <param name="req">参考<see cref="SetLiveWatermarkStatusRequest"/></param>
        /// <returns>参考<see cref="SetLiveWatermarkStatusResponse"/>实例</returns>
        public async Task<SetLiveWatermarkStatusResponse> SetLiveWatermarkStatus(SetLiveWatermarkStatusRequest req)
        {
             JsonResponseModel<SetLiveWatermarkStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetLiveWatermarkStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLiveWatermarkStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 说明：录制后的文件存放于点播平台。用户如需使用录制功能，需首先自行开通点播账号并确保账号可用。录制文件存放后，相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，请参考对应文档。
        /// </summary>
        /// <param name="req">参考<see cref="StopLiveRecordRequest"/></param>
        /// <returns>参考<see cref="StopLiveRecordResponse"/>实例</returns>
        public async Task<StopLiveRecordResponse> StopLiveRecord(StopLiveRecordRequest req)
        {
             JsonResponseModel<StopLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新水印
        /// </summary>
        /// <param name="req">参考<see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="UpdateLiveWatermarkResponse"/>实例</returns>
        public async Task<UpdateLiveWatermarkResponse> UpdateLiveWatermark(UpdateLiveWatermarkRequest req)
        {
             JsonResponseModel<UpdateLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
