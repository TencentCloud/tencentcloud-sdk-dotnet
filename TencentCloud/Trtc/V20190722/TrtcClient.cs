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

namespace TencentCloud.Trtc.V20190722
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trtc.V20190722.Models;

   public class TrtcClient : AbstractClient{

       private const string endpoint = "trtc.tencentcloudapi.com";
       private const string version = "2019-07-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrtcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrtcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 接口说明：
        /// 启动云端录制功能，完成房间内的音视频录制，并上传到指定的云存储。您可以通过此 API 接口把TRTC 房间中的每一路音视频流做单独的录制有或者多路视频画面混流一路。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// * 指定订阅流参数（RecordParams）来指定需要录制的主播的黑名单或者白名单。
        /// * 指定第三方存储的参数（StorageParams）来指定上传到您希望的云存储，目前仅支持云点播存储（CloudVod）
        /// * 指定混流模式下的音视频转码详细参数（MixTranscodeParams），包括视频分辨率、视频码率、视频帧率、以及声音质量等
        /// * 指定混流模式各路画面的位置和布局或者也可以指定自动模板的方式来配置。
        /// 
        /// 关键名词：
        /// * 单流录制：分别录制房间的订阅UserId的音频和视频。录制服务会实时将录制文件上传至云点播存储。
        /// * 合流录制：将房间内订阅UserId的音视频混录成一个音视频文件，并将录制文件上传至云点播存储（录制结束后可前往云点播控制台查看录制文件：https://console.cloud.tencent.com/vod/media）。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRecordingRequest"/></param>
        /// <returns><see cref="CreateCloudRecordingResponse"/></returns>
        public async Task<CreateCloudRecordingResponse> CreateCloudRecording(CreateCloudRecordingRequest req)
        {
             JsonResponseModel<CreateCloudRecordingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudRecording");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudRecordingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：
        /// 启动云端录制功能，完成房间内的音视频录制，并上传到指定的云存储。您可以通过此 API 接口把TRTC 房间中的每一路音视频流做单独的录制有或者多路视频画面混流一路。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// * 指定订阅流参数（RecordParams）来指定需要录制的主播的黑名单或者白名单。
        /// * 指定第三方存储的参数（StorageParams）来指定上传到您希望的云存储，目前仅支持云点播存储（CloudVod）
        /// * 指定混流模式下的音视频转码详细参数（MixTranscodeParams），包括视频分辨率、视频码率、视频帧率、以及声音质量等
        /// * 指定混流模式各路画面的位置和布局或者也可以指定自动模板的方式来配置。
        /// 
        /// 关键名词：
        /// * 单流录制：分别录制房间的订阅UserId的音频和视频。录制服务会实时将录制文件上传至云点播存储。
        /// * 合流录制：将房间内订阅UserId的音视频混录成一个音视频文件，并将录制文件上传至云点播存储（录制结束后可前往云点播控制台查看录制文件：https://console.cloud.tencent.com/vod/media）。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRecordingRequest"/></param>
        /// <returns><see cref="CreateCloudRecordingResponse"/></returns>
        public CreateCloudRecordingResponse CreateCloudRecordingSync(CreateCloudRecordingRequest req)
        {
             JsonResponseModel<CreateCloudRecordingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudRecording");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudRecordingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁新增自定义背景图或水印，可通过此接口上传新的图片素材。无需频繁新增图片的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="CreatePictureRequest"/></param>
        /// <returns><see cref="CreatePictureResponse"/></returns>
        public async Task<CreatePictureResponse> CreatePicture(CreatePictureRequest req)
        {
             JsonResponseModel<CreatePictureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁新增自定义背景图或水印，可通过此接口上传新的图片素材。无需频繁新增图片的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="CreatePictureRequest"/></param>
        /// <returns><see cref="CreatePictureResponse"/></returns>
        public CreatePictureResponse CreatePictureSync(CreatePictureRequest req)
        {
             JsonResponseModel<CreatePictureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来停止录制任务。停止录制成功后不代表文件全部传输完成，如果未完成后台将会继续上传文件，成功后通过事件回调通知客户文件全部传输完成状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudRecordingRequest"/></param>
        /// <returns><see cref="DeleteCloudRecordingResponse"/></returns>
        public async Task<DeleteCloudRecordingResponse> DeleteCloudRecording(DeleteCloudRecordingRequest req)
        {
             JsonResponseModel<DeleteCloudRecordingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCloudRecording");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudRecordingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来停止录制任务。停止录制成功后不代表文件全部传输完成，如果未完成后台将会继续上传文件，成功后通过事件回调通知客户文件全部传输完成状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudRecordingRequest"/></param>
        /// <returns><see cref="DeleteCloudRecordingResponse"/></returns>
        public DeleteCloudRecordingResponse DeleteCloudRecordingSync(DeleteCloudRecordingRequest req)
        {
             JsonResponseModel<DeleteCloudRecordingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCloudRecording");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudRecordingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁删除自定义背景图或水印，可通过此接口删除已上传的图片。无需频繁删除图片的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="DeletePictureRequest"/></param>
        /// <returns><see cref="DeletePictureResponse"/></returns>
        public async Task<DeletePictureResponse> DeletePicture(DeletePictureRequest req)
        {
             JsonResponseModel<DeletePictureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁删除自定义背景图或水印，可通过此接口删除已上传的图片。无需频繁删除图片的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="DeletePictureRequest"/></param>
        /// <returns><see cref="DeletePictureResponse"/></returns>
        public DeletePictureResponse DeletePictureSync(DeletePictureRequest req)
        {
             JsonResponseModel<DeletePictureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间内的用户列表及用户通话质量数据，可查询14天内数据。DataType 不为null，查询起止时间不超过1个小时，查询用户不超过6个，支持跨天查询。DataType为null时，查询起止时间不超过4个小时， 默认查询6个用户，同时支持每页查询100以内用户个数（PageSize不超过100）。接口用于查询质量问题，不推荐作为计费使用。（同老接口DescribeCallDetail）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口目前免费提供中，监控仪表盘商业化计费后该接口需要订阅付费版后方可调用，仪表盘商业化说明请见：https://cloud.tencent.com/document/product/647/77735
        /// </summary>
        /// <param name="req"><see cref="DescribeCallDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeCallDetailInfoResponse"/></returns>
        public async Task<DescribeCallDetailInfoResponse> DescribeCallDetailInfo(DescribeCallDetailInfoRequest req)
        {
             JsonResponseModel<DescribeCallDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCallDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间内的用户列表及用户通话质量数据，可查询14天内数据。DataType 不为null，查询起止时间不超过1个小时，查询用户不超过6个，支持跨天查询。DataType为null时，查询起止时间不超过4个小时， 默认查询6个用户，同时支持每页查询100以内用户个数（PageSize不超过100）。接口用于查询质量问题，不推荐作为计费使用。（同老接口DescribeCallDetail）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口目前免费提供中，监控仪表盘商业化计费后该接口需要订阅付费版后方可调用，仪表盘商业化说明请见：https://cloud.tencent.com/document/product/647/77735
        /// </summary>
        /// <param name="req"><see cref="DescribeCallDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeCallDetailInfoResponse"/></returns>
        public DescribeCallDetailInfoResponse DescribeCallDetailInfoSync(DescribeCallDetailInfoRequest req)
        {
             JsonResponseModel<DescribeCallDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCallDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来查询录制状态。仅在录制任务进行时有效，录制退出后查询将会返回错误。
        /// 录制文件上传到云点播VOD时，StorageFileList中不会返回录制文件信息，请订阅相关录制文件回调事件，获取录制文件信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRecordingRequest"/></param>
        /// <returns><see cref="DescribeCloudRecordingResponse"/></returns>
        public async Task<DescribeCloudRecordingResponse> DescribeCloudRecording(DescribeCloudRecordingRequest req)
        {
             JsonResponseModel<DescribeCloudRecordingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudRecording");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudRecordingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来查询录制状态。仅在录制任务进行时有效，录制退出后查询将会返回错误。
        /// 录制文件上传到云点播VOD时，StorageFileList中不会返回录制文件信息，请订阅相关录制文件回调事件，获取录制文件信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRecordingRequest"/></param>
        /// <returns><see cref="DescribeCloudRecordingResponse"/></returns>
        public DescribeCloudRecordingResponse DescribeCloudRecordingSync(DescribeCloudRecordingRequest req)
        {
             JsonResponseModel<DescribeCloudRecordingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudRecording");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudRecordingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Trtc的用量统计数据。走计费渠道二期 只允许查两天的数据
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalTrtcMeasureRequest"/></param>
        /// <returns><see cref="DescribeExternalTrtcMeasureResponse"/></returns>
        public async Task<DescribeExternalTrtcMeasureResponse> DescribeExternalTrtcMeasure(DescribeExternalTrtcMeasureRequest req)
        {
             JsonResponseModel<DescribeExternalTrtcMeasureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExternalTrtcMeasure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExternalTrtcMeasureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Trtc的用量统计数据。走计费渠道二期 只允许查两天的数据
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalTrtcMeasureRequest"/></param>
        /// <returns><see cref="DescribeExternalTrtcMeasureResponse"/></returns>
        public DescribeExternalTrtcMeasureResponse DescribeExternalTrtcMeasureSync(DescribeExternalTrtcMeasureRequest req)
        {
             JsonResponseModel<DescribeExternalTrtcMeasureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExternalTrtcMeasure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExternalTrtcMeasureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TRTC混流转码的用量明细。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用。
        /// - 默认接口请求频率限制：5次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeMixTranscodingUsageRequest"/></param>
        /// <returns><see cref="DescribeMixTranscodingUsageResponse"/></returns>
        public async Task<DescribeMixTranscodingUsageResponse> DescribeMixTranscodingUsage(DescribeMixTranscodingUsageRequest req)
        {
             JsonResponseModel<DescribeMixTranscodingUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMixTranscodingUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMixTranscodingUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TRTC混流转码的用量明细。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用。
        /// - 默认接口请求频率限制：5次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeMixTranscodingUsageRequest"/></param>
        /// <returns><see cref="DescribeMixTranscodingUsageResponse"/></returns>
        public DescribeMixTranscodingUsageResponse DescribeMixTranscodingUsageSync(DescribeMixTranscodingUsageRequest req)
        {
             JsonResponseModel<DescribeMixTranscodingUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMixTranscodingUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMixTranscodingUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁查找自定义背景图或水印信息，可通过此接口查找已上传的图片信息。无需频繁查找图片信息的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中查看。
        /// </summary>
        /// <param name="req"><see cref="DescribePictureRequest"/></param>
        /// <returns><see cref="DescribePictureResponse"/></returns>
        public async Task<DescribePictureResponse> DescribePicture(DescribePictureRequest req)
        {
             JsonResponseModel<DescribePictureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁查找自定义背景图或水印信息，可通过此接口查找已上传的图片信息。无需频繁查找图片信息的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中查看。
        /// </summary>
        /// <param name="req"><see cref="DescribePictureRequest"/></param>
        /// <returns><see cref="DescribePictureResponse"/></returns>
        public DescribePictureResponse DescribePictureSync(DescribePictureRequest req)
        {
             JsonResponseModel<DescribePictureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云端录制计费时长。
        /// 
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 日结后付费将于次日上午推送账单，建议次日上午9点以后再来查询前一天的用量。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordStatisticRequest"/></param>
        /// <returns><see cref="DescribeRecordStatisticResponse"/></returns>
        public async Task<DescribeRecordStatisticResponse> DescribeRecordStatistic(DescribeRecordStatisticRequest req)
        {
             JsonResponseModel<DescribeRecordStatisticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云端录制计费时长。
        /// 
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 日结后付费将于次日上午推送账单，建议次日上午9点以后再来查询前一天的用量。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordStatisticRequest"/></param>
        /// <returns><see cref="DescribeRecordStatisticResponse"/></returns>
        public DescribeRecordStatisticResponse DescribeRecordStatisticSync(DescribeRecordStatisticRequest req)
        {
             JsonResponseModel<DescribeRecordStatisticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TRTC录制的用量明细。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用。
        /// - 默认接口请求频率限制：5次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingUsageRequest"/></param>
        /// <returns><see cref="DescribeRecordingUsageResponse"/></returns>
        public async Task<DescribeRecordingUsageResponse> DescribeRecordingUsage(DescribeRecordingUsageRequest req)
        {
             JsonResponseModel<DescribeRecordingUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordingUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordingUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TRTC录制的用量明细。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用。
        /// - 默认接口请求频率限制：5次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingUsageRequest"/></param>
        /// <returns><see cref="DescribeRecordingUsageResponse"/></returns>
        public DescribeRecordingUsageResponse DescribeRecordingUsageSync(DescribeRecordingUsageRequest req)
        {
             JsonResponseModel<DescribeRecordingUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordingUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordingUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TRTC旁路转推的用量明细。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用。
        /// - 默认接口请求频率限制：5次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeRelayUsageRequest"/></param>
        /// <returns><see cref="DescribeRelayUsageResponse"/></returns>
        public async Task<DescribeRelayUsageResponse> DescribeRelayUsage(DescribeRelayUsageRequest req)
        {
             JsonResponseModel<DescribeRelayUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRelayUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelayUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TRTC旁路转推的用量明细。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用。
        /// - 默认接口请求频率限制：5次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeRelayUsageRequest"/></param>
        /// <returns><see cref="DescribeRelayUsageResponse"/></returns>
        public DescribeRelayUsageResponse DescribeRelayUsageSync(DescribeRelayUsageRequest req)
        {
             JsonResponseModel<DescribeRelayUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRelayUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelayUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SdkAppId下的房间列表。默认返回10条通话，一次最多返回100条通话。可查询14天内的数据。（同老接口DescribeRoomInformation）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口目前免费提供中，监控仪表盘商业化计费后该接口需要订阅付费版后方可调用，仪表盘商业化说明请见：https://cloud.tencent.com/document/product/647/77735
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInfoRequest"/></param>
        /// <returns><see cref="DescribeRoomInfoResponse"/></returns>
        public async Task<DescribeRoomInfoResponse> DescribeRoomInfo(DescribeRoomInfoRequest req)
        {
             JsonResponseModel<DescribeRoomInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoomInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SdkAppId下的房间列表。默认返回10条通话，一次最多返回100条通话。可查询14天内的数据。（同老接口DescribeRoomInformation）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口目前免费提供中，监控仪表盘商业化计费后该接口需要订阅付费版后方可调用，仪表盘商业化说明请见：https://cloud.tencent.com/document/product/647/77735
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInfoRequest"/></param>
        /// <returns><see cref="DescribeRoomInfoResponse"/></returns>
        public DescribeRoomInfoResponse DescribeRoomInfoSync(DescribeRoomInfoRequest req)
        {
             JsonResponseModel<DescribeRoomInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoomInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可查询SdkAppId每天的房间数和用户数，按天统计，可查询最近14天的数据。当天未结束，数据未统计完成，无法查到当天的房间数与用户数。（同老接口DescribeHistoryScale） 
        /// </summary>
        /// <param name="req"><see cref="DescribeScaleInfoRequest"/></param>
        /// <returns><see cref="DescribeScaleInfoResponse"/></returns>
        public async Task<DescribeScaleInfoResponse> DescribeScaleInfo(DescribeScaleInfoRequest req)
        {
             JsonResponseModel<DescribeScaleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScaleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScaleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可查询SdkAppId每天的房间数和用户数，按天统计，可查询最近14天的数据。当天未结束，数据未统计完成，无法查到当天的房间数与用户数。（同老接口DescribeHistoryScale） 
        /// </summary>
        /// <param name="req"><see cref="DescribeScaleInfoRequest"/></param>
        /// <returns><see cref="DescribeScaleInfoResponse"/></returns>
        public DescribeScaleInfoResponse DescribeScaleInfoSync(DescribeScaleInfoRequest req)
        {
             JsonResponseModel<DescribeScaleInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScaleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScaleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询旁路转码计费时长。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 日结后付费将于次日上午推送账单，建议次日上午9点以后再来查询前一天的用量。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcMcuTranscodeTimeRequest"/></param>
        /// <returns><see cref="DescribeTrtcMcuTranscodeTimeResponse"/></returns>
        public async Task<DescribeTrtcMcuTranscodeTimeResponse> DescribeTrtcMcuTranscodeTime(DescribeTrtcMcuTranscodeTimeRequest req)
        {
             JsonResponseModel<DescribeTrtcMcuTranscodeTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrtcMcuTranscodeTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrtcMcuTranscodeTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询旁路转码计费时长。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 日结后付费将于次日上午推送账单，建议次日上午9点以后再来查询前一天的用量。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcMcuTranscodeTimeRequest"/></param>
        /// <returns><see cref="DescribeTrtcMcuTranscodeTimeResponse"/></returns>
        public DescribeTrtcMcuTranscodeTimeResponse DescribeTrtcMcuTranscodeTimeSync(DescribeTrtcMcuTranscodeTimeRequest req)
        {
             JsonResponseModel<DescribeTrtcMcuTranscodeTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrtcMcuTranscodeTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrtcMcuTranscodeTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TRTC音视频互动的用量明细。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用。
        /// - 默认接口请求频率限制：5次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcUsageRequest"/></param>
        /// <returns><see cref="DescribeTrtcUsageResponse"/></returns>
        public async Task<DescribeTrtcUsageResponse> DescribeTrtcUsage(DescribeTrtcUsageRequest req)
        {
             JsonResponseModel<DescribeTrtcUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrtcUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrtcUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TRTC音视频互动的用量明细。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用。
        /// - 默认接口请求频率限制：5次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcUsageRequest"/></param>
        /// <returns><see cref="DescribeTrtcUsageResponse"/></returns>
        public DescribeTrtcUsageResponse DescribeTrtcUsageSync(DescribeTrtcUsageRequest req)
        {
             JsonResponseModel<DescribeTrtcUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrtcUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrtcUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SdkAppId下任意20条异常体验事件，返回异常体验ID与可能产生异常体验的原因。可查询14天内数据，查询起止时间不超过1个小时。支持跨天查询。（同老接口DescribeAbnormalEvent）
        /// 异常体验ID映射见：https://cloud.tencent.com/document/product/647/44916
        /// </summary>
        /// <param name="req"><see cref="DescribeUnusualEventRequest"/></param>
        /// <returns><see cref="DescribeUnusualEventResponse"/></returns>
        public async Task<DescribeUnusualEventResponse> DescribeUnusualEvent(DescribeUnusualEventRequest req)
        {
             JsonResponseModel<DescribeUnusualEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnusualEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnusualEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SdkAppId下任意20条异常体验事件，返回异常体验ID与可能产生异常体验的原因。可查询14天内数据，查询起止时间不超过1个小时。支持跨天查询。（同老接口DescribeAbnormalEvent）
        /// 异常体验ID映射见：https://cloud.tencent.com/document/product/647/44916
        /// </summary>
        /// <param name="req"><see cref="DescribeUnusualEventRequest"/></param>
        /// <returns><see cref="DescribeUnusualEventResponse"/></returns>
        public DescribeUnusualEventResponse DescribeUnusualEventSync(DescribeUnusualEventRequest req)
        {
             JsonResponseModel<DescribeUnusualEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnusualEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnusualEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户某次通话内的进退房，视频开关等详细事件。可查询14天内数据。（同接口DescribeDetailEvent）
        /// </summary>
        /// <param name="req"><see cref="DescribeUserEventRequest"/></param>
        /// <returns><see cref="DescribeUserEventResponse"/></returns>
        public async Task<DescribeUserEventResponse> DescribeUserEvent(DescribeUserEventRequest req)
        {
             JsonResponseModel<DescribeUserEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户某次通话内的进退房，视频开关等详细事件。可查询14天内数据。（同接口DescribeDetailEvent）
        /// </summary>
        /// <param name="req"><see cref="DescribeUserEventRequest"/></param>
        /// <returns><see cref="DescribeUserEventResponse"/></returns>
        public DescribeUserEventResponse DescribeUserEventSync(DescribeUserEventRequest req)
        {
             JsonResponseModel<DescribeUserEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间内的用户列表，可查询14天内数据，查询起止时间不超过4小时。默认每页查询6个用户，支持每页最大查询100个用户PageSize不超过100）。（同老接口DescribeUserInformation）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口目前免费提供中，监控仪表盘商业化计费后该接口需要订阅付费版后方可调用，仪表盘商业化说明请见：https://cloud.tencent.com/document/product/647/77735
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public async Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
             JsonResponseModel<DescribeUserInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间内的用户列表，可查询14天内数据，查询起止时间不超过4小时。默认每页查询6个用户，支持每页最大查询100个用户PageSize不超过100）。（同老接口DescribeUserInformation）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口目前免费提供中，监控仪表盘商业化计费后该接口需要订阅付费版后方可调用，仪表盘商业化说明请见：https://cloud.tencent.com/document/product/647/77735
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
             JsonResponseModel<DescribeUserInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间移出，解散房间。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public async Task<DismissRoomResponse> DismissRoom(DismissRoomRequest req)
        {
             JsonResponseModel<DismissRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DismissRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DismissRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间移出，解散房间。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public DismissRoomResponse DismissRoomSync(DismissRoomRequest req)
        {
             JsonResponseModel<DismissRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DismissRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DismissRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间移出，解散房间。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="DismissRoomByStrRoomIdRequest"/></param>
        /// <returns><see cref="DismissRoomByStrRoomIdResponse"/></returns>
        public async Task<DismissRoomByStrRoomIdResponse> DismissRoomByStrRoomId(DismissRoomByStrRoomIdRequest req)
        {
             JsonResponseModel<DismissRoomByStrRoomIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DismissRoomByStrRoomId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DismissRoomByStrRoomIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间移出，解散房间。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="DismissRoomByStrRoomIdRequest"/></param>
        /// <returns><see cref="DismissRoomByStrRoomIdResponse"/></returns>
        public DismissRoomByStrRoomIdResponse DismissRoomByStrRoomIdSync(DismissRoomByStrRoomIdRequest req)
        {
             JsonResponseModel<DismissRoomByStrRoomIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DismissRoomByStrRoomId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DismissRoomByStrRoomIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来更新录制任务。仅在录制任务进行时有效，录制退出后更新将会返回错误。更新操作是全量覆盖，并不是增量更新的模式，也就是说每次更新都需要携带全量的信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudRecordingRequest"/></param>
        /// <returns><see cref="ModifyCloudRecordingResponse"/></returns>
        public async Task<ModifyCloudRecordingResponse> ModifyCloudRecording(ModifyCloudRecordingRequest req)
        {
             JsonResponseModel<ModifyCloudRecordingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCloudRecording");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudRecordingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来更新录制任务。仅在录制任务进行时有效，录制退出后更新将会返回错误。更新操作是全量覆盖，并不是增量更新的模式，也就是说每次更新都需要携带全量的信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudRecordingRequest"/></param>
        /// <returns><see cref="ModifyCloudRecordingResponse"/></returns>
        public ModifyCloudRecordingResponse ModifyCloudRecordingSync(ModifyCloudRecordingRequest req)
        {
             JsonResponseModel<ModifyCloudRecordingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCloudRecording");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudRecordingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁修改自定义背景图或水印素材，可通过此接口修改已上传的图片。无需频繁修改图片素材的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyPictureRequest"/></param>
        /// <returns><see cref="ModifyPictureResponse"/></returns>
        public async Task<ModifyPictureResponse> ModifyPicture(ModifyPictureRequest req)
        {
             JsonResponseModel<ModifyPictureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁修改自定义背景图或水印素材，可通过此接口修改已上传的图片。无需频繁修改图片素材的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyPictureRequest"/></param>
        /// <returns><see cref="ModifyPictureResponse"/></returns>
        public ModifyPictureResponse ModifyPictureSync(ModifyPictureRequest req)
        {
             JsonResponseModel<ModifyPictureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPicture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPictureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：将用户从房间移出，适用于主播/房主/管理员踢人等场景。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="RemoveUserRequest"/></param>
        /// <returns><see cref="RemoveUserResponse"/></returns>
        public async Task<RemoveUserResponse> RemoveUser(RemoveUserRequest req)
        {
             JsonResponseModel<RemoveUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：将用户从房间移出，适用于主播/房主/管理员踢人等场景。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="RemoveUserRequest"/></param>
        /// <returns><see cref="RemoveUserResponse"/></returns>
        public RemoveUserResponse RemoveUserSync(RemoveUserRequest req)
        {
             JsonResponseModel<RemoveUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：将用户从房间移出，适用于主播/房主/管理员踢人等场景。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="RemoveUserByStrRoomIdRequest"/></param>
        /// <returns><see cref="RemoveUserByStrRoomIdResponse"/></returns>
        public async Task<RemoveUserByStrRoomIdResponse> RemoveUserByStrRoomId(RemoveUserByStrRoomIdRequest req)
        {
             JsonResponseModel<RemoveUserByStrRoomIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveUserByStrRoomId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserByStrRoomIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：将用户从房间移出，适用于主播/房主/管理员踢人等场景。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="RemoveUserByStrRoomIdRequest"/></param>
        /// <returns><see cref="RemoveUserByStrRoomIdResponse"/></returns>
        public RemoveUserByStrRoomIdResponse RemoveUserByStrRoomIdSync(RemoveUserByStrRoomIdRequest req)
        {
             JsonResponseModel<RemoveUserByStrRoomIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveUserByStrRoomId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserByStrRoomIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：启动云端混流，并指定混流画面中各路画面的布局位置。
        /// 
        /// TRTC 的一个房间中可能会同时存在多路音视频流，您可以通过此 API 接口，通知腾讯云服务端将多路视频画面合成一路，并指定每一路画面的位置，同时将多路声音进行混音，最终形成一路音视频流，以便用于录制和直播观看。房间销毁后混流自动结束。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// - 设置最终直播流的画质和音质，包括视频分辨率、视频码率、视频帧率、以及声音质量等。
        /// - 设置各路画面的位置和布局，您只需要在启动时设置一次，排版引擎会自动完成后续的画面排布。
        /// - 设置录制文件名，用于二次回放。
        /// - 设置 CDN 直播流 ID，用于在 CDN 进行直播观看。
        /// 
        /// 目前已经支持了如下几种布局模板：
        /// - 悬浮模板：第一个进入房间的用户的视频画面会铺满整个屏幕，其他用户的视频画面从左下角依次水平排列，显示为小画面，最多4行，每行4个，小画面悬浮于大画面之上。最多支持1个大画面和15个小画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 九宫格模板：所有用户的视频画面大小一致，平分整个屏幕，人数越多，每个画面的尺寸越小。最多支持16个画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 屏幕分享模板：适合视频会议和在线教育场景的布局，屏幕分享（或者主讲的摄像头）始终占据屏幕左侧的大画面位置，其他用户依次垂直排列于右侧，最多两列，每列最多8个小画面。最多支持1个大画面和15个小画面。若上行分辨率宽高比与画面输出宽高比不一致时，左侧大画面为了保持内容的完整性采用缩放方式处理，右侧小画面采用裁剪方式处理。
        /// - 画中画模板：适用于混合大小两路视频画面和其他用户混音，或者混合一路大画面和其他用户混音的场景。小画面悬浮于大画面之上，可以指定大小画面的用户以及小画面的显示位置，最多支持2个画面。
        /// - 自定义模板：适用于在混流中指定用户的画面位置，或者预设视频画面位置的场景。当预设位置指定用户时，排版引擎会该用户预留位置；当预设位置未指定用户时，排版引擎会根据进房间顺序自动填充。预设位置填满时，不再混合其他用户的画面和声音。自定义模板启用占位图功能时（LayoutParams中的PlaceHolderMode设置成1），在预设位置的用户没有上行视频时可显示对应的占位图（PlaceImageId）。
        /// 
        /// 注意：
        /// 1、**混流转码为收费功能，调用接口将产生云端混流转码费用，详见[云端混流转码计费说明](https://cloud.tencent.com/document/product/647/49446)。**
        /// 2、2020年1月9号及以后创建的应用才能直接调用此接口。2020年1月9日之前创建的应用默认使用云直播的云端混流，如需切换至MCU混流，请[提交工单](https://console.cloud.tencent.com/workorder/category)寻求帮助。
        /// 3、客户端混流和服务端混流不能混用。
        /// </summary>
        /// <param name="req"><see cref="StartMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StartMCUMixTranscodeResponse"/></returns>
        public async Task<StartMCUMixTranscodeResponse> StartMCUMixTranscode(StartMCUMixTranscodeRequest req)
        {
             JsonResponseModel<StartMCUMixTranscodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartMCUMixTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMCUMixTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：启动云端混流，并指定混流画面中各路画面的布局位置。
        /// 
        /// TRTC 的一个房间中可能会同时存在多路音视频流，您可以通过此 API 接口，通知腾讯云服务端将多路视频画面合成一路，并指定每一路画面的位置，同时将多路声音进行混音，最终形成一路音视频流，以便用于录制和直播观看。房间销毁后混流自动结束。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// - 设置最终直播流的画质和音质，包括视频分辨率、视频码率、视频帧率、以及声音质量等。
        /// - 设置各路画面的位置和布局，您只需要在启动时设置一次，排版引擎会自动完成后续的画面排布。
        /// - 设置录制文件名，用于二次回放。
        /// - 设置 CDN 直播流 ID，用于在 CDN 进行直播观看。
        /// 
        /// 目前已经支持了如下几种布局模板：
        /// - 悬浮模板：第一个进入房间的用户的视频画面会铺满整个屏幕，其他用户的视频画面从左下角依次水平排列，显示为小画面，最多4行，每行4个，小画面悬浮于大画面之上。最多支持1个大画面和15个小画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 九宫格模板：所有用户的视频画面大小一致，平分整个屏幕，人数越多，每个画面的尺寸越小。最多支持16个画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 屏幕分享模板：适合视频会议和在线教育场景的布局，屏幕分享（或者主讲的摄像头）始终占据屏幕左侧的大画面位置，其他用户依次垂直排列于右侧，最多两列，每列最多8个小画面。最多支持1个大画面和15个小画面。若上行分辨率宽高比与画面输出宽高比不一致时，左侧大画面为了保持内容的完整性采用缩放方式处理，右侧小画面采用裁剪方式处理。
        /// - 画中画模板：适用于混合大小两路视频画面和其他用户混音，或者混合一路大画面和其他用户混音的场景。小画面悬浮于大画面之上，可以指定大小画面的用户以及小画面的显示位置，最多支持2个画面。
        /// - 自定义模板：适用于在混流中指定用户的画面位置，或者预设视频画面位置的场景。当预设位置指定用户时，排版引擎会该用户预留位置；当预设位置未指定用户时，排版引擎会根据进房间顺序自动填充。预设位置填满时，不再混合其他用户的画面和声音。自定义模板启用占位图功能时（LayoutParams中的PlaceHolderMode设置成1），在预设位置的用户没有上行视频时可显示对应的占位图（PlaceImageId）。
        /// 
        /// 注意：
        /// 1、**混流转码为收费功能，调用接口将产生云端混流转码费用，详见[云端混流转码计费说明](https://cloud.tencent.com/document/product/647/49446)。**
        /// 2、2020年1月9号及以后创建的应用才能直接调用此接口。2020年1月9日之前创建的应用默认使用云直播的云端混流，如需切换至MCU混流，请[提交工单](https://console.cloud.tencent.com/workorder/category)寻求帮助。
        /// 3、客户端混流和服务端混流不能混用。
        /// </summary>
        /// <param name="req"><see cref="StartMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StartMCUMixTranscodeResponse"/></returns>
        public StartMCUMixTranscodeResponse StartMCUMixTranscodeSync(StartMCUMixTranscodeRequest req)
        {
             JsonResponseModel<StartMCUMixTranscodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartMCUMixTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMCUMixTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：启动云端混流，并指定混流画面中各路画面的布局位置。
        /// 
        /// TRTC 的一个房间中可能会同时存在多路音视频流，您可以通过此 API 接口，通知腾讯云服务端将多路视频画面合成一路，并指定每一路画面的位置，同时将多路声音进行混音，最终形成一路音视频流，以便用于录制和直播观看。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// - 设置最终直播流的画质和音质，包括视频分辨率、视频码率、视频帧率、以及声音质量等。
        /// - 设置各路画面的位置和布局，您只需要在启动时设置一次，排版引擎会自动完成后续的画面排布。
        /// - 设置录制文件名，用于二次回放。
        /// - 设置 CDN 直播流 ID，用于在 CDN 进行直播观看。
        /// 
        /// 目前已经支持了如下几种布局模板：
        /// - 悬浮模板：第一个进入房间的用户的视频画面会铺满整个屏幕，其他用户的视频画面从左下角依次水平排列，显示为小画面，最多4行，每行4个，小画面悬浮于大画面之上。最多支持1个大画面和15个小画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 九宫格模板：所有用户的视频画面大小一致，平分整个屏幕，人数越多，每个画面的尺寸越小。最多支持16个画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 屏幕分享模板：适合视频会议和在线教育场景的布局，屏幕分享（或者主讲的摄像头）始终占据屏幕左侧的大画面位置，其他用户依次垂直排列于右侧，最多两列，每列最多8个小画面。最多支持1个大画面和15个小画面。若上行分辨率宽高比与画面输出宽高比不一致时，左侧大画面为了保持内容的完整性采用缩放方式处理，右侧小画面采用裁剪方式处理。
        /// - 画中画模板：适用于混合大小两路视频画面和其他用户混音，或者混合一路大画面和其他用户混音的场景。小画面悬浮于大画面之上，可以指定大小画面的用户以及小画面的显示位置。
        /// - 自定义模板：适用于在混流中指定用户的画面位置，或者预设视频画面位置的场景。当预设位置指定用户时，排版引擎会该用户预留位置；当预设位置未指定用户时，排版引擎会根据进房间顺序自动填充。预设位置填满时，不再混合其他用户的画面和声音。自定义模板启用占位图功能时（LayoutParams中的PlaceHolderMode设置成1），在预设位置的用户没有上行视频时可显示对应的占位图（PlaceImageId）。
        /// 
        /// 注意：
        /// 1、**混流转码为收费功能，调用接口将产生云端混流转码费用，详见[云端混流转码计费说明](https://cloud.tencent.com/document/product/647/49446)。**
        /// 2、2020年1月9号及以后创建的应用才能直接调用此接口。2020年1月9日之前创建的应用默认使用云直播的云端混流，如需切换至MCU混流，请[提交工单](https://console.cloud.tencent.com/workorder/category)寻求帮助。
        /// 3、客户端混流和服务端混流不能混用。
        /// </summary>
        /// <param name="req"><see cref="StartMCUMixTranscodeByStrRoomIdRequest"/></param>
        /// <returns><see cref="StartMCUMixTranscodeByStrRoomIdResponse"/></returns>
        public async Task<StartMCUMixTranscodeByStrRoomIdResponse> StartMCUMixTranscodeByStrRoomId(StartMCUMixTranscodeByStrRoomIdRequest req)
        {
             JsonResponseModel<StartMCUMixTranscodeByStrRoomIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartMCUMixTranscodeByStrRoomId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMCUMixTranscodeByStrRoomIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：启动云端混流，并指定混流画面中各路画面的布局位置。
        /// 
        /// TRTC 的一个房间中可能会同时存在多路音视频流，您可以通过此 API 接口，通知腾讯云服务端将多路视频画面合成一路，并指定每一路画面的位置，同时将多路声音进行混音，最终形成一路音视频流，以便用于录制和直播观看。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// - 设置最终直播流的画质和音质，包括视频分辨率、视频码率、视频帧率、以及声音质量等。
        /// - 设置各路画面的位置和布局，您只需要在启动时设置一次，排版引擎会自动完成后续的画面排布。
        /// - 设置录制文件名，用于二次回放。
        /// - 设置 CDN 直播流 ID，用于在 CDN 进行直播观看。
        /// 
        /// 目前已经支持了如下几种布局模板：
        /// - 悬浮模板：第一个进入房间的用户的视频画面会铺满整个屏幕，其他用户的视频画面从左下角依次水平排列，显示为小画面，最多4行，每行4个，小画面悬浮于大画面之上。最多支持1个大画面和15个小画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 九宫格模板：所有用户的视频画面大小一致，平分整个屏幕，人数越多，每个画面的尺寸越小。最多支持16个画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 屏幕分享模板：适合视频会议和在线教育场景的布局，屏幕分享（或者主讲的摄像头）始终占据屏幕左侧的大画面位置，其他用户依次垂直排列于右侧，最多两列，每列最多8个小画面。最多支持1个大画面和15个小画面。若上行分辨率宽高比与画面输出宽高比不一致时，左侧大画面为了保持内容的完整性采用缩放方式处理，右侧小画面采用裁剪方式处理。
        /// - 画中画模板：适用于混合大小两路视频画面和其他用户混音，或者混合一路大画面和其他用户混音的场景。小画面悬浮于大画面之上，可以指定大小画面的用户以及小画面的显示位置。
        /// - 自定义模板：适用于在混流中指定用户的画面位置，或者预设视频画面位置的场景。当预设位置指定用户时，排版引擎会该用户预留位置；当预设位置未指定用户时，排版引擎会根据进房间顺序自动填充。预设位置填满时，不再混合其他用户的画面和声音。自定义模板启用占位图功能时（LayoutParams中的PlaceHolderMode设置成1），在预设位置的用户没有上行视频时可显示对应的占位图（PlaceImageId）。
        /// 
        /// 注意：
        /// 1、**混流转码为收费功能，调用接口将产生云端混流转码费用，详见[云端混流转码计费说明](https://cloud.tencent.com/document/product/647/49446)。**
        /// 2、2020年1月9号及以后创建的应用才能直接调用此接口。2020年1月9日之前创建的应用默认使用云直播的云端混流，如需切换至MCU混流，请[提交工单](https://console.cloud.tencent.com/workorder/category)寻求帮助。
        /// 3、客户端混流和服务端混流不能混用。
        /// </summary>
        /// <param name="req"><see cref="StartMCUMixTranscodeByStrRoomIdRequest"/></param>
        /// <returns><see cref="StartMCUMixTranscodeByStrRoomIdResponse"/></returns>
        public StartMCUMixTranscodeByStrRoomIdResponse StartMCUMixTranscodeByStrRoomIdSync(StartMCUMixTranscodeByStrRoomIdRequest req)
        {
             JsonResponseModel<StartMCUMixTranscodeByStrRoomIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartMCUMixTranscodeByStrRoomId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMCUMixTranscodeByStrRoomIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：结束云端混流
        /// </summary>
        /// <param name="req"><see cref="StopMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StopMCUMixTranscodeResponse"/></returns>
        public async Task<StopMCUMixTranscodeResponse> StopMCUMixTranscode(StopMCUMixTranscodeRequest req)
        {
             JsonResponseModel<StopMCUMixTranscodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopMCUMixTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMCUMixTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：结束云端混流
        /// </summary>
        /// <param name="req"><see cref="StopMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StopMCUMixTranscodeResponse"/></returns>
        public StopMCUMixTranscodeResponse StopMCUMixTranscodeSync(StopMCUMixTranscodeRequest req)
        {
             JsonResponseModel<StopMCUMixTranscodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopMCUMixTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMCUMixTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：结束云端混流
        /// </summary>
        /// <param name="req"><see cref="StopMCUMixTranscodeByStrRoomIdRequest"/></param>
        /// <returns><see cref="StopMCUMixTranscodeByStrRoomIdResponse"/></returns>
        public async Task<StopMCUMixTranscodeByStrRoomIdResponse> StopMCUMixTranscodeByStrRoomId(StopMCUMixTranscodeByStrRoomIdRequest req)
        {
             JsonResponseModel<StopMCUMixTranscodeByStrRoomIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopMCUMixTranscodeByStrRoomId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMCUMixTranscodeByStrRoomIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：结束云端混流
        /// </summary>
        /// <param name="req"><see cref="StopMCUMixTranscodeByStrRoomIdRequest"/></param>
        /// <returns><see cref="StopMCUMixTranscodeByStrRoomIdResponse"/></returns>
        public StopMCUMixTranscodeByStrRoomIdResponse StopMCUMixTranscodeByStrRoomIdSync(StopMCUMixTranscodeByStrRoomIdRequest req)
        {
             JsonResponseModel<StopMCUMixTranscodeByStrRoomIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopMCUMixTranscodeByStrRoomId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMCUMixTranscodeByStrRoomIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
