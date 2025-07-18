/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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
       private const string sdkVersion = "SDK_NET_3.0.1282";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrtcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 提供服务端控制机器人的功能
        /// </summary>
        /// <param name="req"><see cref="ControlAIConversationRequest"/></param>
        /// <returns><see cref="ControlAIConversationResponse"/></returns>
        public Task<ControlAIConversationResponse> ControlAIConversation(ControlAIConversationRequest req)
        {
            return InternalRequestAsync<ControlAIConversationResponse>(req, "ControlAIConversation");
        }

        /// <summary>
        /// 提供服务端控制机器人的功能
        /// </summary>
        /// <param name="req"><see cref="ControlAIConversationRequest"/></param>
        /// <returns><see cref="ControlAIConversationResponse"/></returns>
        public ControlAIConversationResponse ControlAIConversationSync(ControlAIConversationRequest req)
        {
            return InternalRequestAsync<ControlAIConversationResponse>(req, "ControlAIConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：
        /// 启动终端审核功能，完成房间内的音频审核。
        /// </summary>
        /// <param name="req"><see cref="CreateBasicModerationRequest"/></param>
        /// <returns><see cref="CreateBasicModerationResponse"/></returns>
        public Task<CreateBasicModerationResponse> CreateBasicModeration(CreateBasicModerationRequest req)
        {
            return InternalRequestAsync<CreateBasicModerationResponse>(req, "CreateBasicModeration");
        }

        /// <summary>
        /// 接口说明：
        /// 启动终端审核功能，完成房间内的音频审核。
        /// </summary>
        /// <param name="req"><see cref="CreateBasicModerationRequest"/></param>
        /// <returns><see cref="CreateBasicModerationResponse"/></returns>
        public CreateBasicModerationResponse CreateBasicModerationSync(CreateBasicModerationRequest req)
        {
            return InternalRequestAsync<CreateBasicModerationResponse>(req, "CreateBasicModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：
        /// 启动云端审核功能，完成房间内的音视频切片，视频截帧，或者录制音频流，送审到指定的审核商，完成审核。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// * 指定审核参数（ModerationParams）来指定审核需要的详细参数。
        /// * 指定存储参数（ModerationStorageParams）将命中的审核文件指定上传到您希望的云存储，目前支持腾讯云（对象存储COS）和第三方AWS
        /// </summary>
        /// <param name="req"><see cref="CreateCloudModerationRequest"/></param>
        /// <returns><see cref="CreateCloudModerationResponse"/></returns>
        public Task<CreateCloudModerationResponse> CreateCloudModeration(CreateCloudModerationRequest req)
        {
            return InternalRequestAsync<CreateCloudModerationResponse>(req, "CreateCloudModeration");
        }

        /// <summary>
        /// 接口说明：
        /// 启动云端审核功能，完成房间内的音视频切片，视频截帧，或者录制音频流，送审到指定的审核商，完成审核。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// * 指定审核参数（ModerationParams）来指定审核需要的详细参数。
        /// * 指定存储参数（ModerationStorageParams）将命中的审核文件指定上传到您希望的云存储，目前支持腾讯云（对象存储COS）和第三方AWS
        /// </summary>
        /// <param name="req"><see cref="CreateCloudModerationRequest"/></param>
        /// <returns><see cref="CreateCloudModerationResponse"/></returns>
        public CreateCloudModerationResponse CreateCloudModerationSync(CreateCloudModerationRequest req)
        {
            return InternalRequestAsync<CreateCloudModerationResponse>(req, "CreateCloudModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：
        /// 启动云端录制功能，完成房间内的音视频录制，并上传到指定的云存储。您可以通过此 API 接口把TRTC 房间中的每一路音视频流做单独的录制又或者多路视频画面合流混成一路。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// * 指定订阅流参数（RecordParams）来指定需要录制的主播的黑名单或者白名单。
        /// * 指定录制存储参数（StorageParams）来指定上传到您希望的云存储，目前支持腾讯云（云点播VOD、对象存储COS）和第三方AWS
        /// * 指定合流模式下的音视频转码详细参数（MixTranscodeParams），包括视频分辨率、视频码率、视频帧率、以及声音质量等
        /// * 指定合流模式各路画面的位置和布局或者也可以指定自动模板的方式来配置。
        /// 
        /// 关键名词：
        /// * 单流录制：分别录制房间的订阅UserId的音频和视频，录制服务会实时将录制文件上传至您指定的云存储。
        /// * 合流录制：将房间内订阅UserId的音视频混录成一个视频文件，并将录制文件上传至您指定的云存储。（录制结束后可前往云点播控制台https://console.cloud.tencent.com/vod/media 或 对象存储COS控制台https://console.cloud.tencent.com/cos/bucket查看文件）。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRecordingRequest"/></param>
        /// <returns><see cref="CreateCloudRecordingResponse"/></returns>
        public Task<CreateCloudRecordingResponse> CreateCloudRecording(CreateCloudRecordingRequest req)
        {
            return InternalRequestAsync<CreateCloudRecordingResponse>(req, "CreateCloudRecording");
        }

        /// <summary>
        /// 接口说明：
        /// 启动云端录制功能，完成房间内的音视频录制，并上传到指定的云存储。您可以通过此 API 接口把TRTC 房间中的每一路音视频流做单独的录制又或者多路视频画面合流混成一路。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// * 指定订阅流参数（RecordParams）来指定需要录制的主播的黑名单或者白名单。
        /// * 指定录制存储参数（StorageParams）来指定上传到您希望的云存储，目前支持腾讯云（云点播VOD、对象存储COS）和第三方AWS
        /// * 指定合流模式下的音视频转码详细参数（MixTranscodeParams），包括视频分辨率、视频码率、视频帧率、以及声音质量等
        /// * 指定合流模式各路画面的位置和布局或者也可以指定自动模板的方式来配置。
        /// 
        /// 关键名词：
        /// * 单流录制：分别录制房间的订阅UserId的音频和视频，录制服务会实时将录制文件上传至您指定的云存储。
        /// * 合流录制：将房间内订阅UserId的音视频混录成一个视频文件，并将录制文件上传至您指定的云存储。（录制结束后可前往云点播控制台https://console.cloud.tencent.com/vod/media 或 对象存储COS控制台https://console.cloud.tencent.com/cos/bucket查看文件）。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRecordingRequest"/></param>
        /// <returns><see cref="CreateCloudRecordingResponse"/></returns>
        public CreateCloudRecordingResponse CreateCloudRecordingSync(CreateCloudRecordingRequest req)
        {
            return InternalRequestAsync<CreateCloudRecordingResponse>(req, "CreateCloudRecording")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：
        /// 启动云端切片功能，完成房间内的音视频切片，并上传到指定的云存储。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// * 指定切片参数（SliceParams）来指定需要切片的主播的黑名单或者白名单。
        /// * 指定存储参数（SliceStorageParams）来指定上传到您希望的云存储，目前支持腾讯云（对象存储COS）和第三方AWS
        /// </summary>
        /// <param name="req"><see cref="CreateCloudSliceTaskRequest"/></param>
        /// <returns><see cref="CreateCloudSliceTaskResponse"/></returns>
        public Task<CreateCloudSliceTaskResponse> CreateCloudSliceTask(CreateCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<CreateCloudSliceTaskResponse>(req, "CreateCloudSliceTask");
        }

        /// <summary>
        /// 接口说明：
        /// 启动云端切片功能，完成房间内的音视频切片，并上传到指定的云存储。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// * 指定切片参数（SliceParams）来指定需要切片的主播的黑名单或者白名单。
        /// * 指定存储参数（SliceStorageParams）来指定上传到您希望的云存储，目前支持腾讯云（对象存储COS）和第三方AWS
        /// </summary>
        /// <param name="req"><see cref="CreateCloudSliceTaskRequest"/></param>
        /// <returns><see cref="CreateCloudSliceTaskResponse"/></returns>
        public CreateCloudSliceTaskResponse CreateCloudSliceTaskSync(CreateCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<CreateCloudSliceTaskResponse>(req, "CreateCloudSliceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁新增自定义背景图或水印，可通过此接口上传新的图片素材。无需频繁新增图片的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="CreatePictureRequest"/></param>
        /// <returns><see cref="CreatePictureResponse"/></returns>
        public Task<CreatePictureResponse> CreatePicture(CreatePictureRequest req)
        {
            return InternalRequestAsync<CreatePictureResponse>(req, "CreatePicture");
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁新增自定义背景图或水印，可通过此接口上传新的图片素材。无需频繁新增图片的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="CreatePictureRequest"/></param>
        /// <returns><see cref="CreatePictureResponse"/></returns>
        public CreatePictureResponse CreatePictureSync(CreatePictureRequest req)
        {
            return InternalRequestAsync<CreatePictureResponse>(req, "CreatePicture")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启审核任务后，可以使用此接口来停止任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteBasicModerationRequest"/></param>
        /// <returns><see cref="DeleteBasicModerationResponse"/></returns>
        public Task<DeleteBasicModerationResponse> DeleteBasicModeration(DeleteBasicModerationRequest req)
        {
            return InternalRequestAsync<DeleteBasicModerationResponse>(req, "DeleteBasicModeration");
        }

        /// <summary>
        /// 成功开启审核任务后，可以使用此接口来停止任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteBasicModerationRequest"/></param>
        /// <returns><see cref="DeleteBasicModerationResponse"/></returns>
        public DeleteBasicModerationResponse DeleteBasicModerationSync(DeleteBasicModerationRequest req)
        {
            return InternalRequestAsync<DeleteBasicModerationResponse>(req, "DeleteBasicModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启云端审核任务后，可以使用此接口来停止送审。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudModerationRequest"/></param>
        /// <returns><see cref="DeleteCloudModerationResponse"/></returns>
        public Task<DeleteCloudModerationResponse> DeleteCloudModeration(DeleteCloudModerationRequest req)
        {
            return InternalRequestAsync<DeleteCloudModerationResponse>(req, "DeleteCloudModeration");
        }

        /// <summary>
        /// 成功开启云端审核任务后，可以使用此接口来停止送审。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudModerationRequest"/></param>
        /// <returns><see cref="DeleteCloudModerationResponse"/></returns>
        public DeleteCloudModerationResponse DeleteCloudModerationSync(DeleteCloudModerationRequest req)
        {
            return InternalRequestAsync<DeleteCloudModerationResponse>(req, "DeleteCloudModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来停止录制任务。停止录制成功后不代表文件全部传输完成，如果未完成后台将会继续上传文件，成功后通过事件回调通知客户文件全部传输完成状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudRecordingRequest"/></param>
        /// <returns><see cref="DeleteCloudRecordingResponse"/></returns>
        public Task<DeleteCloudRecordingResponse> DeleteCloudRecording(DeleteCloudRecordingRequest req)
        {
            return InternalRequestAsync<DeleteCloudRecordingResponse>(req, "DeleteCloudRecording");
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来停止录制任务。停止录制成功后不代表文件全部传输完成，如果未完成后台将会继续上传文件，成功后通过事件回调通知客户文件全部传输完成状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudRecordingRequest"/></param>
        /// <returns><see cref="DeleteCloudRecordingResponse"/></returns>
        public DeleteCloudRecordingResponse DeleteCloudRecordingSync(DeleteCloudRecordingRequest req)
        {
            return InternalRequestAsync<DeleteCloudRecordingResponse>(req, "DeleteCloudRecording")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启切片任务后，可以使用此接口来停止任务。停止切片成功后不代表文件全部传输完成，如果未完成后台将会继续上传文件，成功后通过事件回调通知客户文件全部传输完成状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudSliceTaskRequest"/></param>
        /// <returns><see cref="DeleteCloudSliceTaskResponse"/></returns>
        public Task<DeleteCloudSliceTaskResponse> DeleteCloudSliceTask(DeleteCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<DeleteCloudSliceTaskResponse>(req, "DeleteCloudSliceTask");
        }

        /// <summary>
        /// 成功开启切片任务后，可以使用此接口来停止任务。停止切片成功后不代表文件全部传输完成，如果未完成后台将会继续上传文件，成功后通过事件回调通知客户文件全部传输完成状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudSliceTaskRequest"/></param>
        /// <returns><see cref="DeleteCloudSliceTaskResponse"/></returns>
        public DeleteCloudSliceTaskResponse DeleteCloudSliceTaskSync(DeleteCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<DeleteCloudSliceTaskResponse>(req, "DeleteCloudSliceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁删除自定义背景图或水印，可通过此接口删除已上传的图片。无需频繁删除图片的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="DeletePictureRequest"/></param>
        /// <returns><see cref="DeletePictureResponse"/></returns>
        public Task<DeletePictureResponse> DeletePicture(DeletePictureRequest req)
        {
            return InternalRequestAsync<DeletePictureResponse>(req, "DeletePicture");
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁删除自定义背景图或水印，可通过此接口删除已上传的图片。无需频繁删除图片的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="DeletePictureRequest"/></param>
        /// <returns><see cref="DeletePictureResponse"/></returns>
        public DeletePictureResponse DeletePictureSync(DeletePictureRequest req)
        {
            return InternalRequestAsync<DeletePictureResponse>(req, "DeletePicture")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 传入声纹ID，删除之前注册的声纹信息
        /// </summary>
        /// <param name="req"><see cref="DeleteVoicePrintRequest"/></param>
        /// <returns><see cref="DeleteVoicePrintResponse"/></returns>
        public Task<DeleteVoicePrintResponse> DeleteVoicePrint(DeleteVoicePrintRequest req)
        {
            return InternalRequestAsync<DeleteVoicePrintResponse>(req, "DeleteVoicePrint");
        }

        /// <summary>
        /// 传入声纹ID，删除之前注册的声纹信息
        /// </summary>
        /// <param name="req"><see cref="DeleteVoicePrintRequest"/></param>
        /// <returns><see cref="DeleteVoicePrintResponse"/></returns>
        public DeleteVoicePrintResponse DeleteVoicePrintSync(DeleteVoicePrintRequest req)
        {
            return InternalRequestAsync<DeleteVoicePrintResponse>(req, "DeleteVoicePrint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI对话任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIConversationRequest"/></param>
        /// <returns><see cref="DescribeAIConversationResponse"/></returns>
        public Task<DescribeAIConversationResponse> DescribeAIConversation(DescribeAIConversationRequest req)
        {
            return InternalRequestAsync<DescribeAIConversationResponse>(req, "DescribeAIConversation");
        }

        /// <summary>
        /// 查询AI对话任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIConversationRequest"/></param>
        /// <returns><see cref="DescribeAIConversationResponse"/></returns>
        public DescribeAIConversationResponse DescribeAIConversationSync(DescribeAIConversationRequest req)
        {
            return InternalRequestAsync<DescribeAIConversationResponse>(req, "DescribeAIConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI转录任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeAITranscriptionRequest"/></param>
        /// <returns><see cref="DescribeAITranscriptionResponse"/></returns>
        public Task<DescribeAITranscriptionResponse> DescribeAITranscription(DescribeAITranscriptionRequest req)
        {
            return InternalRequestAsync<DescribeAITranscriptionResponse>(req, "DescribeAITranscription");
        }

        /// <summary>
        /// 查询AI转录任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeAITranscriptionRequest"/></param>
        /// <returns><see cref="DescribeAITranscriptionResponse"/></returns>
        public DescribeAITranscriptionResponse DescribeAITranscriptionSync(DescribeAITranscriptionRequest req)
        {
            return InternalRequestAsync<DescribeAITranscriptionResponse>(req, "DescribeAITranscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定时间内的用户列表及用户通话质量数据，最大可查询14天内数据。DataType 不为null，查询起止时间不超过1个小时，查询用户不超过6个，支持跨天查询。DataType为null时，查询起止时间不超过4个小时， 默认查询6个用户，同时支持每页查询100以内用户个数（PageSize不超过100）。接口用于查询质量问题，不推荐作为计费使用。（同老接口DescribeCallDetail）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口自2024年4月1日起正式商业化，需订阅套餐解锁调用能力，提供以下两种解锁方式，可任选其一解锁：
        /// 方式一：通过订阅[包月套餐](https://cloud.tencent.com/document/product/647/85386)「尊享版」（可查近7天）和「旗舰版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc?trtcversion=top)。
        /// 方式二：通过订阅[监控仪表盘](https://cloud.tencent.com/document/product/647/81331)商业套餐包「基础版」（可查近7天）和「进阶版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc_monitor)。
        /// </summary>
        /// <param name="req"><see cref="DescribeCallDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeCallDetailInfoResponse"/></returns>
        public Task<DescribeCallDetailInfoResponse> DescribeCallDetailInfo(DescribeCallDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeCallDetailInfoResponse>(req, "DescribeCallDetailInfo");
        }

        /// <summary>
        /// 查询指定时间内的用户列表及用户通话质量数据，最大可查询14天内数据。DataType 不为null，查询起止时间不超过1个小时，查询用户不超过6个，支持跨天查询。DataType为null时，查询起止时间不超过4个小时， 默认查询6个用户，同时支持每页查询100以内用户个数（PageSize不超过100）。接口用于查询质量问题，不推荐作为计费使用。（同老接口DescribeCallDetail）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口自2024年4月1日起正式商业化，需订阅套餐解锁调用能力，提供以下两种解锁方式，可任选其一解锁：
        /// 方式一：通过订阅[包月套餐](https://cloud.tencent.com/document/product/647/85386)「尊享版」（可查近7天）和「旗舰版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc?trtcversion=top)。
        /// 方式二：通过订阅[监控仪表盘](https://cloud.tencent.com/document/product/647/81331)商业套餐包「基础版」（可查近7天）和「进阶版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc_monitor)。
        /// </summary>
        /// <param name="req"><see cref="DescribeCallDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeCallDetailInfoResponse"/></returns>
        public DescribeCallDetailInfoResponse DescribeCallDetailInfoSync(DescribeCallDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeCallDetailInfoResponse>(req, "DescribeCallDetailInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启审核任务后，可以使用此接口来查询审核任务状态和订阅的黑白名单信息。仅在任务进行时有效，任务退出后查询将会返回错误。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudModerationRequest"/></param>
        /// <returns><see cref="DescribeCloudModerationResponse"/></returns>
        public Task<DescribeCloudModerationResponse> DescribeCloudModeration(DescribeCloudModerationRequest req)
        {
            return InternalRequestAsync<DescribeCloudModerationResponse>(req, "DescribeCloudModeration");
        }

        /// <summary>
        /// 成功开启审核任务后，可以使用此接口来查询审核任务状态和订阅的黑白名单信息。仅在任务进行时有效，任务退出后查询将会返回错误。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudModerationRequest"/></param>
        /// <returns><see cref="DescribeCloudModerationResponse"/></returns>
        public DescribeCloudModerationResponse DescribeCloudModerationSync(DescribeCloudModerationRequest req)
        {
            return InternalRequestAsync<DescribeCloudModerationResponse>(req, "DescribeCloudModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来查询录制状态。仅在录制任务进行时有效，录制退出后查询将会返回错误。
        /// 录制文件上传到云点播VOD时，StorageFileList中不会返回录制文件信息，请订阅相关录制文件回调事件，获取录制文件信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRecordingRequest"/></param>
        /// <returns><see cref="DescribeCloudRecordingResponse"/></returns>
        public Task<DescribeCloudRecordingResponse> DescribeCloudRecording(DescribeCloudRecordingRequest req)
        {
            return InternalRequestAsync<DescribeCloudRecordingResponse>(req, "DescribeCloudRecording");
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来查询录制状态。仅在录制任务进行时有效，录制退出后查询将会返回错误。
        /// 录制文件上传到云点播VOD时，StorageFileList中不会返回录制文件信息，请订阅相关录制文件回调事件，获取录制文件信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRecordingRequest"/></param>
        /// <returns><see cref="DescribeCloudRecordingResponse"/></returns>
        public DescribeCloudRecordingResponse DescribeCloudRecordingSync(DescribeCloudRecordingRequest req)
        {
            return InternalRequestAsync<DescribeCloudRecordingResponse>(req, "DescribeCloudRecording")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启切片后，可以使用此接口来查询切片任务状态。仅在任务进行时有效，任务退出后查询将会返回错误。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudSliceTaskRequest"/></param>
        /// <returns><see cref="DescribeCloudSliceTaskResponse"/></returns>
        public Task<DescribeCloudSliceTaskResponse> DescribeCloudSliceTask(DescribeCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<DescribeCloudSliceTaskResponse>(req, "DescribeCloudSliceTask");
        }

        /// <summary>
        /// 成功开启切片后，可以使用此接口来查询切片任务状态。仅在任务进行时有效，任务退出后查询将会返回错误。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudSliceTaskRequest"/></param>
        /// <returns><see cref="DescribeCloudSliceTaskResponse"/></returns>
        public DescribeCloudSliceTaskResponse DescribeCloudSliceTaskSync(DescribeCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<DescribeCloudSliceTaskResponse>(req, "DescribeCloudSliceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeMixTranscodingUsageResponse> DescribeMixTranscodingUsage(DescribeMixTranscodingUsageRequest req)
        {
            return InternalRequestAsync<DescribeMixTranscodingUsageResponse>(req, "DescribeMixTranscodingUsage");
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
            return InternalRequestAsync<DescribeMixTranscodingUsageResponse>(req, "DescribeMixTranscodingUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁查找自定义背景图或水印信息，可通过此接口查找已上传的图片信息。无需频繁查找图片信息的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中查看。
        /// </summary>
        /// <param name="req"><see cref="DescribePictureRequest"/></param>
        /// <returns><see cref="DescribePictureResponse"/></returns>
        public Task<DescribePictureResponse> DescribePicture(DescribePictureRequest req)
        {
            return InternalRequestAsync<DescribePictureResponse>(req, "DescribePicture");
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁查找自定义背景图或水印信息，可通过此接口查找已上传的图片信息。无需频繁查找图片信息的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中查看。
        /// </summary>
        /// <param name="req"><see cref="DescribePictureRequest"/></param>
        /// <returns><see cref="DescribePictureResponse"/></returns>
        public DescribePictureResponse DescribePictureSync(DescribePictureRequest req)
        {
            return InternalRequestAsync<DescribePictureResponse>(req, "DescribePicture")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeRecordStatisticResponse> DescribeRecordStatistic(DescribeRecordStatisticRequest req)
        {
            return InternalRequestAsync<DescribeRecordStatisticResponse>(req, "DescribeRecordStatistic");
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
            return InternalRequestAsync<DescribeRecordStatisticResponse>(req, "DescribeRecordStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeRecordingUsageResponse> DescribeRecordingUsage(DescribeRecordingUsageRequest req)
        {
            return InternalRequestAsync<DescribeRecordingUsageResponse>(req, "DescribeRecordingUsage");
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
            return InternalRequestAsync<DescribeRecordingUsageResponse>(req, "DescribeRecordingUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeRelayUsageResponse> DescribeRelayUsage(DescribeRelayUsageRequest req)
        {
            return InternalRequestAsync<DescribeRelayUsageResponse>(req, "DescribeRelayUsage");
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
            return InternalRequestAsync<DescribeRelayUsageResponse>(req, "DescribeRelayUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询SdkAppId下的房间列表。默认返回10条通话，一次最多返回100条通话。最大可查询14天内的数据。（同老接口DescribeRoomInformation）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口自2024年4月1日起正式商业化，需订阅套餐解锁调用能力，提供以下两种解锁方式，可任意其一解锁：
        /// 方式一：通过订阅[包月套餐](https://cloud.tencent.com/document/product/647/85386)「尊享版」（可查近7天）和「旗舰版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc?trtcversion=top)。
        /// 方式二：通过订阅[监控仪表盘](https://cloud.tencent.com/document/product/647/81331)商业套餐包「基础版」（可查近7天）和「进阶版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc_monitor)。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInfoRequest"/></param>
        /// <returns><see cref="DescribeRoomInfoResponse"/></returns>
        public Task<DescribeRoomInfoResponse> DescribeRoomInfo(DescribeRoomInfoRequest req)
        {
            return InternalRequestAsync<DescribeRoomInfoResponse>(req, "DescribeRoomInfo");
        }

        /// <summary>
        /// 查询SdkAppId下的房间列表。默认返回10条通话，一次最多返回100条通话。最大可查询14天内的数据。（同老接口DescribeRoomInformation）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口自2024年4月1日起正式商业化，需订阅套餐解锁调用能力，提供以下两种解锁方式，可任意其一解锁：
        /// 方式一：通过订阅[包月套餐](https://cloud.tencent.com/document/product/647/85386)「尊享版」（可查近7天）和「旗舰版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc?trtcversion=top)。
        /// 方式二：通过订阅[监控仪表盘](https://cloud.tencent.com/document/product/647/81331)商业套餐包「基础版」（可查近7天）和「进阶版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc_monitor)。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInfoRequest"/></param>
        /// <returns><see cref="DescribeRoomInfoResponse"/></returns>
        public DescribeRoomInfoResponse DescribeRoomInfoSync(DescribeRoomInfoRequest req)
        {
            return InternalRequestAsync<DescribeRoomInfoResponse>(req, "DescribeRoomInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可查询SdkAppId每天的房间数和用户数，按天统计，可查询最近14天的数据。当天未结束，数据未统计完成，无法查到当天的房间数与用户数。（同老接口DescribeHistoryScale）
        /// </summary>
        /// <param name="req"><see cref="DescribeScaleInfoRequest"/></param>
        /// <returns><see cref="DescribeScaleInfoResponse"/></returns>
        public Task<DescribeScaleInfoResponse> DescribeScaleInfo(DescribeScaleInfoRequest req)
        {
            return InternalRequestAsync<DescribeScaleInfoResponse>(req, "DescribeScaleInfo");
        }

        /// <summary>
        /// 可查询SdkAppId每天的房间数和用户数，按天统计，可查询最近14天的数据。当天未结束，数据未统计完成，无法查到当天的房间数与用户数。（同老接口DescribeHistoryScale）
        /// </summary>
        /// <param name="req"><see cref="DescribeScaleInfoRequest"/></param>
        /// <returns><see cref="DescribeScaleInfoResponse"/></returns>
        public DescribeScaleInfoResponse DescribeScaleInfoSync(DescribeScaleInfoRequest req)
        {
            return InternalRequestAsync<DescribeScaleInfoResponse>(req, "DescribeScaleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 您可以查询输入在线媒体流任务的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamIngestRequest"/></param>
        /// <returns><see cref="DescribeStreamIngestResponse"/></returns>
        public Task<DescribeStreamIngestResponse> DescribeStreamIngest(DescribeStreamIngestRequest req)
        {
            return InternalRequestAsync<DescribeStreamIngestResponse>(req, "DescribeStreamIngest");
        }

        /// <summary>
        /// 您可以查询输入在线媒体流任务的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamIngestRequest"/></param>
        /// <returns><see cref="DescribeStreamIngestResponse"/></returns>
        public DescribeStreamIngestResponse DescribeStreamIngestSync(DescribeStreamIngestRequest req)
        {
            return InternalRequestAsync<DescribeStreamIngestResponse>(req, "DescribeStreamIngest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-数据大盘质量指标（包括下列指标）
        /// joinSuccessRate：加入频道成功率。
        /// joinSuccessIn5sRate：5s内加入频道成功率。
        /// audioFreezeRate：音频卡顿率。
        /// videoFreezeRate：视频卡顿率。
        /// networkDelay ：网络延迟率。
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘[版本功能和计费说明](https://cloud.tencent.com/document/product/647/81331)。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，【基础版】可查近30天，【进阶版】可查近60天。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketQualityDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketQualityDataResponse"/></returns>
        public Task<DescribeTRTCMarketQualityDataResponse> DescribeTRTCMarketQualityData(DescribeTRTCMarketQualityDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketQualityDataResponse>(req, "DescribeTRTCMarketQualityData");
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-数据大盘质量指标（包括下列指标）
        /// joinSuccessRate：加入频道成功率。
        /// joinSuccessIn5sRate：5s内加入频道成功率。
        /// audioFreezeRate：音频卡顿率。
        /// videoFreezeRate：视频卡顿率。
        /// networkDelay ：网络延迟率。
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘[版本功能和计费说明](https://cloud.tencent.com/document/product/647/81331)。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，【基础版】可查近30天，【进阶版】可查近60天。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketQualityDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketQualityDataResponse"/></returns>
        public DescribeTRTCMarketQualityDataResponse DescribeTRTCMarketQualityDataSync(DescribeTRTCMarketQualityDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketQualityDataResponse>(req, "DescribeTRTCMarketQualityData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-数据大盘质量指标（包括下列指标）
        /// joinSuccessRate：加入频道成功率。
        /// joinSuccessIn5sRate：5s内加入频道成功率。
        /// audioFreezeRate：音频卡顿率。
        /// videoFreezeRate：视频卡顿率。
        /// networkDelay ：网络延迟率。
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘版本功能和计费说明：https://cloud.tencent.com/document/product/647/81331。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，【基础版】可查近30天，【进阶版】可查近60天。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketQualityMetricDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketQualityMetricDataResponse"/></returns>
        public Task<DescribeTRTCMarketQualityMetricDataResponse> DescribeTRTCMarketQualityMetricData(DescribeTRTCMarketQualityMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketQualityMetricDataResponse>(req, "DescribeTRTCMarketQualityMetricData");
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-数据大盘质量指标（包括下列指标）
        /// joinSuccessRate：加入频道成功率。
        /// joinSuccessIn5sRate：5s内加入频道成功率。
        /// audioFreezeRate：音频卡顿率。
        /// videoFreezeRate：视频卡顿率。
        /// networkDelay ：网络延迟率。
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘版本功能和计费说明：https://cloud.tencent.com/document/product/647/81331。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，【基础版】可查近30天，【进阶版】可查近60天。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketQualityMetricDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketQualityMetricDataResponse"/></returns>
        public DescribeTRTCMarketQualityMetricDataResponse DescribeTRTCMarketQualityMetricDataSync(DescribeTRTCMarketQualityMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketQualityMetricDataResponse>(req, "DescribeTRTCMarketQualityMetricData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-数据大盘规模指标（会返回通话人数，通话房间数，峰值同时在线人数，峰值同时在线频道数）
        /// userCount：通话人数，
        /// roomCount：通话房间数，从有用户加入频道到所有用户离开频道计为一个通话频道。
        /// peakCurrentChannels：峰值同时在线频道数。
        /// peakCurrentUsers：峰值同时在线人数。
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘[版本功能和计费说明](https://cloud.tencent.com/document/product/647/81331)。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，【基础版】可查近30天，【进阶版】可查近60天。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketScaleDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketScaleDataResponse"/></returns>
        public Task<DescribeTRTCMarketScaleDataResponse> DescribeTRTCMarketScaleData(DescribeTRTCMarketScaleDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketScaleDataResponse>(req, "DescribeTRTCMarketScaleData");
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-数据大盘规模指标（会返回通话人数，通话房间数，峰值同时在线人数，峰值同时在线频道数）
        /// userCount：通话人数，
        /// roomCount：通话房间数，从有用户加入频道到所有用户离开频道计为一个通话频道。
        /// peakCurrentChannels：峰值同时在线频道数。
        /// peakCurrentUsers：峰值同时在线人数。
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘[版本功能和计费说明](https://cloud.tencent.com/document/product/647/81331)。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，【基础版】可查近30天，【进阶版】可查近60天。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketScaleDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketScaleDataResponse"/></returns>
        public DescribeTRTCMarketScaleDataResponse DescribeTRTCMarketScaleDataSync(DescribeTRTCMarketScaleDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketScaleDataResponse>(req, "DescribeTRTCMarketScaleData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-数据大盘规模指标（会返回通话人数，通话房间数，峰值同时在线人数，峰值同时在线频道数）
        /// userCount：通话人数，
        /// roomCount：通话房间数，从有用户加入频道到所有用户离开频道计为一个通话频道。
        /// peakCurrentChannels：峰值同时在线频道数。
        /// peakCurrentUsers：峰值同时在线人数。
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘版本功能和计费说明：https://cloud.tencent.com/document/product/647/81331。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，【基础版】可查近30天，【进阶版】可查近60天。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketScaleMetricDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketScaleMetricDataResponse"/></returns>
        public Task<DescribeTRTCMarketScaleMetricDataResponse> DescribeTRTCMarketScaleMetricData(DescribeTRTCMarketScaleMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketScaleMetricDataResponse>(req, "DescribeTRTCMarketScaleMetricData");
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-数据大盘规模指标（会返回通话人数，通话房间数，峰值同时在线人数，峰值同时在线频道数）
        /// userCount：通话人数，
        /// roomCount：通话房间数，从有用户加入频道到所有用户离开频道计为一个通话频道。
        /// peakCurrentChannels：峰值同时在线频道数。
        /// peakCurrentUsers：峰值同时在线人数。
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘版本功能和计费说明：https://cloud.tencent.com/document/product/647/81331。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，【基础版】可查近30天，【进阶版】可查近60天。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketScaleMetricDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketScaleMetricDataResponse"/></returns>
        public DescribeTRTCMarketScaleMetricDataResponse DescribeTRTCMarketScaleMetricDataSync(DescribeTRTCMarketScaleMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketScaleMetricDataResponse>(req, "DescribeTRTCMarketScaleMetricData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-实时监控质量指标（会返回下列指标）
        /// -视频卡顿率
        /// -音频卡顿率
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，详情参考[监控仪表盘](https://cloud.tencent.com/document/product/647/81331)。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，基础版可查近3小时，进阶版可查近12小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeQualityDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeQualityDataResponse"/></returns>
        public Task<DescribeTRTCRealTimeQualityDataResponse> DescribeTRTCRealTimeQualityData(DescribeTRTCRealTimeQualityDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeQualityDataResponse>(req, "DescribeTRTCRealTimeQualityData");
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-实时监控质量指标（会返回下列指标）
        /// -视频卡顿率
        /// -音频卡顿率
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，详情参考[监控仪表盘](https://cloud.tencent.com/document/product/647/81331)。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，基础版可查近3小时，进阶版可查近12小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeQualityDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeQualityDataResponse"/></returns>
        public DescribeTRTCRealTimeQualityDataResponse DescribeTRTCRealTimeQualityDataSync(DescribeTRTCRealTimeQualityDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeQualityDataResponse>(req, "DescribeTRTCRealTimeQualityData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-实时监控质量指标（会返回下列指标）
        /// -视频卡顿率
        /// -音频卡顿率
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘版本功能和计费说明：https://cloud.tencent.com/document/product/647/81331。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，基础版可查近3小时，进阶版可查近12小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeQualityMetricDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeQualityMetricDataResponse"/></returns>
        public Task<DescribeTRTCRealTimeQualityMetricDataResponse> DescribeTRTCRealTimeQualityMetricData(DescribeTRTCRealTimeQualityMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeQualityMetricDataResponse>(req, "DescribeTRTCRealTimeQualityMetricData");
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-实时监控质量指标（会返回下列指标）
        /// -视频卡顿率
        /// -音频卡顿率
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘版本功能和计费说明：https://cloud.tencent.com/document/product/647/81331。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，基础版可查近3小时，进阶版可查近12小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeQualityMetricDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeQualityMetricDataResponse"/></returns>
        public DescribeTRTCRealTimeQualityMetricDataResponse DescribeTRTCRealTimeQualityMetricDataSync(DescribeTRTCRealTimeQualityMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeQualityMetricDataResponse>(req, "DescribeTRTCRealTimeQualityMetricData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-实时监控规模指标（会返回下列指标）
        /// -userCount（在线用户数）
        /// -roomCount（在线房间数）
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，详情参考[监控仪表盘](https://cloud.tencent.com/document/product/647/81331)。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，基础版可查近3小时，进阶版可查近12小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeScaleDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeScaleDataResponse"/></returns>
        public Task<DescribeTRTCRealTimeScaleDataResponse> DescribeTRTCRealTimeScaleData(DescribeTRTCRealTimeScaleDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeScaleDataResponse>(req, "DescribeTRTCRealTimeScaleData");
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-实时监控规模指标（会返回下列指标）
        /// -userCount（在线用户数）
        /// -roomCount（在线房间数）
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，详情参考[监控仪表盘](https://cloud.tencent.com/document/product/647/81331)。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，基础版可查近3小时，进阶版可查近12小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeScaleDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeScaleDataResponse"/></returns>
        public DescribeTRTCRealTimeScaleDataResponse DescribeTRTCRealTimeScaleDataSync(DescribeTRTCRealTimeScaleDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeScaleDataResponse>(req, "DescribeTRTCRealTimeScaleData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-实时监控规模指标（会返回下列指标）
        /// -userCount（在线用户数）
        /// -roomCount（在线房间数）
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘版本功能和计费说明：https://cloud.tencent.com/document/product/647/81331。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，基础版可查近3小时，进阶版可查近12小时。
        /// xa0
        /// 3.除此之外您也可以通过订阅TRTC包月套餐(https://buy.cloud.tencent.com/trtc)尊享版或旗舰版解锁此接口（DescribeTRTCRealTimeScaleMetricData）的调用能力，请在开通包月套餐后，请提交工单联系售后解锁调用能力https://console.cloud.tencent.com/workorder/category
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeScaleMetricDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeScaleMetricDataResponse"/></returns>
        public Task<DescribeTRTCRealTimeScaleMetricDataResponse> DescribeTRTCRealTimeScaleMetricData(DescribeTRTCRealTimeScaleMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeScaleMetricDataResponse>(req, "DescribeTRTCRealTimeScaleMetricData");
        }

        /// <summary>
        /// 查询TRTC监控仪表盘-实时监控规模指标（会返回下列指标）
        /// -userCount（在线用户数）
        /// -roomCount（在线房间数）
        /// 注意：
        /// 1.调用接口需开通监控仪表盘【基础版】和【进阶版】，监控仪表盘【免费版】不支持调用，监控仪表盘版本功能和计费说明：https://cloud.tencent.com/document/product/647/81331。
        /// 2.查询时间范围根据监控仪表盘功能版本而定，基础版可查近3小时，进阶版可查近12小时。
        /// xa0
        /// 3.除此之外您也可以通过订阅TRTC包月套餐(https://buy.cloud.tencent.com/trtc)尊享版或旗舰版解锁此接口（DescribeTRTCRealTimeScaleMetricData）的调用能力，请在开通包月套餐后，请提交工单联系售后解锁调用能力https://console.cloud.tencent.com/workorder/category
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeScaleMetricDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeScaleMetricDataResponse"/></returns>
        public DescribeTRTCRealTimeScaleMetricDataResponse DescribeTRTCRealTimeScaleMetricDataSync(DescribeTRTCRealTimeScaleMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeScaleMetricDataResponse>(req, "DescribeTRTCRealTimeScaleMetricData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeTrtcMcuTranscodeTimeResponse> DescribeTrtcMcuTranscodeTime(DescribeTrtcMcuTranscodeTimeRequest req)
        {
            return InternalRequestAsync<DescribeTrtcMcuTranscodeTimeResponse>(req, "DescribeTrtcMcuTranscodeTime");
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
            return InternalRequestAsync<DescribeTrtcMcuTranscodeTimeResponse>(req, "DescribeTrtcMcuTranscodeTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TRTC音视频房间维度用量。
        /// - 单次只能查询一天数据，返回查询时间段内的汇总数据；通过多次查询可以查不同天数据。若查询跨天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用，不可用于账单核对，如需对账请使用账号/应用维度用量API：DescribeTrtcUsage。
        /// - 默认接口请求频率限制：1次/15秒。
        /// - 数据最早可查日期为2023年4月1日0点，最大可查范围近3个月。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcRoomUsageRequest"/></param>
        /// <returns><see cref="DescribeTrtcRoomUsageResponse"/></returns>
        public Task<DescribeTrtcRoomUsageResponse> DescribeTrtcRoomUsage(DescribeTrtcRoomUsageRequest req)
        {
            return InternalRequestAsync<DescribeTrtcRoomUsageResponse>(req, "DescribeTrtcRoomUsage");
        }

        /// <summary>
        /// 查询TRTC音视频房间维度用量。
        /// - 单次只能查询一天数据，返回查询时间段内的汇总数据；通过多次查询可以查不同天数据。若查询跨天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用，不可用于账单核对，如需对账请使用账号/应用维度用量API：DescribeTrtcUsage。
        /// - 默认接口请求频率限制：1次/15秒。
        /// - 数据最早可查日期为2023年4月1日0点，最大可查范围近3个月。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcRoomUsageRequest"/></param>
        /// <returns><see cref="DescribeTrtcRoomUsageResponse"/></returns>
        public DescribeTrtcRoomUsageResponse DescribeTrtcRoomUsageSync(DescribeTrtcRoomUsageRequest req)
        {
            return InternalRequestAsync<DescribeTrtcRoomUsageResponse>(req, "DescribeTrtcRoomUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取TRTC音视频互动的用量明细，单位:分钟。
        /// - 查询时间小于等于1天时，返回每5分钟粒度的数据；查询时间大于1天时，返回按天汇总的数据。
        /// - 单次查询统计区间最多不能超过31天。
        /// - 若查询当天用量，由于统计延迟等原因，返回数据可能不够准确。
        /// - 该接口只用于历史用量数据统计或核对数据使用，关键业务逻辑不能使用。
        /// - 默认接口请求频率限制：5次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcUsageRequest"/></param>
        /// <returns><see cref="DescribeTrtcUsageResponse"/></returns>
        public Task<DescribeTrtcUsageResponse> DescribeTrtcUsage(DescribeTrtcUsageRequest req)
        {
            return InternalRequestAsync<DescribeTrtcUsageResponse>(req, "DescribeTrtcUsage");
        }

        /// <summary>
        /// 获取TRTC音视频互动的用量明细，单位:分钟。
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
            return InternalRequestAsync<DescribeTrtcUsageResponse>(req, "DescribeTrtcUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询SdkAppId下任意20条异常体验事件，返回异常体验ID与可能产生异常体验的原因。可查询14天内数据，查询起止时间不超过1个小时。支持跨天查询。（同老接口DescribeAbnormalEvent）
        /// 异常体验ID映射见：https://cloud.tencent.com/document/product/647/44916
        /// </summary>
        /// <param name="req"><see cref="DescribeUnusualEventRequest"/></param>
        /// <returns><see cref="DescribeUnusualEventResponse"/></returns>
        public Task<DescribeUnusualEventResponse> DescribeUnusualEvent(DescribeUnusualEventRequest req)
        {
            return InternalRequestAsync<DescribeUnusualEventResponse>(req, "DescribeUnusualEvent");
        }

        /// <summary>
        /// 查询SdkAppId下任意20条异常体验事件，返回异常体验ID与可能产生异常体验的原因。可查询14天内数据，查询起止时间不超过1个小时。支持跨天查询。（同老接口DescribeAbnormalEvent）
        /// 异常体验ID映射见：https://cloud.tencent.com/document/product/647/44916
        /// </summary>
        /// <param name="req"><see cref="DescribeUnusualEventRequest"/></param>
        /// <returns><see cref="DescribeUnusualEventResponse"/></returns>
        public DescribeUnusualEventResponse DescribeUnusualEventSync(DescribeUnusualEventRequest req)
        {
            return InternalRequestAsync<DescribeUnusualEventResponse>(req, "DescribeUnusualEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户某次通话内的进退房，视频开关等详细事件。可查询14天内数据。（同接口DescribeDetailEvent）
        /// </summary>
        /// <param name="req"><see cref="DescribeUserEventRequest"/></param>
        /// <returns><see cref="DescribeUserEventResponse"/></returns>
        public Task<DescribeUserEventResponse> DescribeUserEvent(DescribeUserEventRequest req)
        {
            return InternalRequestAsync<DescribeUserEventResponse>(req, "DescribeUserEvent");
        }

        /// <summary>
        /// 查询用户某次通话内的进退房，视频开关等详细事件。可查询14天内数据。（同接口DescribeDetailEvent）
        /// </summary>
        /// <param name="req"><see cref="DescribeUserEventRequest"/></param>
        /// <returns><see cref="DescribeUserEventResponse"/></returns>
        public DescribeUserEventResponse DescribeUserEventSync(DescribeUserEventRequest req)
        {
            return InternalRequestAsync<DescribeUserEventResponse>(req, "DescribeUserEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定时间内的用户列表，最大可查询14天内数据，查询起止时间不超过4小时。默认每页查询6个用户，支持每页最大查询100个用户PageSize不超过100）。（同老接口DescribeUserInformation）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口自2024年4月1日起正式商业化，需订阅套餐解锁调用能力，提供以下两种解锁方式，可任选其一解锁：
        /// 方式一：通过订阅[包月套餐](https://cloud.tencent.com/document/product/647/85386)「尊享版」（可查近7天）和「旗舰版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc?trtcversion=top)。
        /// 方式二：通过订阅[监控仪表盘](https://cloud.tencent.com/document/product/647/81331)商业套餐包「基础版」（可查近7天）和「进阶版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc_monitor)。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo");
        }

        /// <summary>
        /// 查询指定时间内的用户列表，最大可查询14天内数据，查询起止时间不超过4小时。默认每页查询6个用户，支持每页最大查询100个用户PageSize不超过100）。（同老接口DescribeUserInformation）
        /// **注意**：
        /// 1.该接口只用于历史数据统计或核对数据使用，实时类关键业务逻辑不能使用。
        /// 2.该接口自2024年4月1日起正式商业化，需订阅套餐解锁调用能力，提供以下两种解锁方式，可任选其一解锁：
        /// 方式一：通过订阅[包月套餐](https://cloud.tencent.com/document/product/647/85386)「尊享版」（可查近7天）和「旗舰版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc?trtcversion=top)。
        /// 方式二：通过订阅[监控仪表盘](https://cloud.tencent.com/document/product/647/81331)商业套餐包「基础版」（可查近7天）和「进阶版」（可查近14天），[前往订阅](https://buy.cloud.tencent.com/trtc_monitor)。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询先前注册的声纹信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVoicePrintRequest"/></param>
        /// <returns><see cref="DescribeVoicePrintResponse"/></returns>
        public Task<DescribeVoicePrintResponse> DescribeVoicePrint(DescribeVoicePrintRequest req)
        {
            return InternalRequestAsync<DescribeVoicePrintResponse>(req, "DescribeVoicePrint");
        }

        /// <summary>
        /// 查询先前注册的声纹信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVoicePrintRequest"/></param>
        /// <returns><see cref="DescribeVoicePrintResponse"/></returns>
        public DescribeVoicePrintResponse DescribeVoicePrintSync(DescribeVoicePrintRequest req)
        {
            return InternalRequestAsync<DescribeVoicePrintResponse>(req, "DescribeVoicePrint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询页面录制任务
        /// </summary>
        /// <param name="req"><see cref="DescribeWebRecordRequest"/></param>
        /// <returns><see cref="DescribeWebRecordResponse"/></returns>
        public Task<DescribeWebRecordResponse> DescribeWebRecord(DescribeWebRecordRequest req)
        {
            return InternalRequestAsync<DescribeWebRecordResponse>(req, "DescribeWebRecord");
        }

        /// <summary>
        /// 查询页面录制任务
        /// </summary>
        /// <param name="req"><see cref="DescribeWebRecordRequest"/></param>
        /// <returns><see cref="DescribeWebRecordResponse"/></returns>
        public DescribeWebRecordResponse DescribeWebRecordSync(DescribeWebRecordRequest req)
        {
            return InternalRequestAsync<DescribeWebRecordResponse>(req, "DescribeWebRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间移出，解散房间。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public Task<DismissRoomResponse> DismissRoom(DismissRoomRequest req)
        {
            return InternalRequestAsync<DismissRoomResponse>(req, "DismissRoom");
        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间移出，解散房间。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public DismissRoomResponse DismissRoomSync(DismissRoomRequest req)
        {
            return InternalRequestAsync<DismissRoomResponse>(req, "DismissRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间移出，解散房间。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="DismissRoomByStrRoomIdRequest"/></param>
        /// <returns><see cref="DismissRoomByStrRoomIdResponse"/></returns>
        public Task<DismissRoomByStrRoomIdResponse> DismissRoomByStrRoomId(DismissRoomByStrRoomIdRequest req)
        {
            return InternalRequestAsync<DismissRoomByStrRoomIdResponse>(req, "DismissRoomByStrRoomId");
        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间移出，解散房间。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="DismissRoomByStrRoomIdRequest"/></param>
        /// <returns><see cref="DismissRoomByStrRoomIdResponse"/></returns>
        public DismissRoomByStrRoomIdResponse DismissRoomByStrRoomIdSync(DismissRoomByStrRoomIdRequest req)
        {
            return InternalRequestAsync<DismissRoomByStrRoomIdResponse>(req, "DismissRoomByStrRoomId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启云端审核任务后，可以使用此接口来更新订阅黑白名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudModerationRequest"/></param>
        /// <returns><see cref="ModifyCloudModerationResponse"/></returns>
        public Task<ModifyCloudModerationResponse> ModifyCloudModeration(ModifyCloudModerationRequest req)
        {
            return InternalRequestAsync<ModifyCloudModerationResponse>(req, "ModifyCloudModeration");
        }

        /// <summary>
        /// 成功开启云端审核任务后，可以使用此接口来更新订阅黑白名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudModerationRequest"/></param>
        /// <returns><see cref="ModifyCloudModerationResponse"/></returns>
        public ModifyCloudModerationResponse ModifyCloudModerationSync(ModifyCloudModerationRequest req)
        {
            return InternalRequestAsync<ModifyCloudModerationResponse>(req, "ModifyCloudModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来更新录制任务。仅在录制任务进行时有效，录制退出后更新将会返回错误。更新操作是全量覆盖，并不是增量更新的模式，也就是说每次更新都需要携带全量的信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudRecordingRequest"/></param>
        /// <returns><see cref="ModifyCloudRecordingResponse"/></returns>
        public Task<ModifyCloudRecordingResponse> ModifyCloudRecording(ModifyCloudRecordingRequest req)
        {
            return InternalRequestAsync<ModifyCloudRecordingResponse>(req, "ModifyCloudRecording");
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来更新录制任务。仅在录制任务进行时有效，录制退出后更新将会返回错误。更新操作是全量覆盖，并不是增量更新的模式，也就是说每次更新都需要携带全量的信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudRecordingRequest"/></param>
        /// <returns><see cref="ModifyCloudRecordingResponse"/></returns>
        public ModifyCloudRecordingResponse ModifyCloudRecordingSync(ModifyCloudRecordingRequest req)
        {
            return InternalRequestAsync<ModifyCloudRecordingResponse>(req, "ModifyCloudRecording")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启切片任务后，可以使用此接口来更新任务。用于更新指定订阅流白名单或者黑名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudSliceTaskRequest"/></param>
        /// <returns><see cref="ModifyCloudSliceTaskResponse"/></returns>
        public Task<ModifyCloudSliceTaskResponse> ModifyCloudSliceTask(ModifyCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<ModifyCloudSliceTaskResponse>(req, "ModifyCloudSliceTask");
        }

        /// <summary>
        /// 成功开启切片任务后，可以使用此接口来更新任务。用于更新指定订阅流白名单或者黑名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudSliceTaskRequest"/></param>
        /// <returns><see cref="ModifyCloudSliceTaskResponse"/></returns>
        public ModifyCloudSliceTaskResponse ModifyCloudSliceTaskSync(ModifyCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<ModifyCloudSliceTaskResponse>(req, "ModifyCloudSliceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁修改自定义背景图或水印素材，可通过此接口修改已上传的图片。无需频繁修改图片素材的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyPictureRequest"/></param>
        /// <returns><see cref="ModifyPictureResponse"/></returns>
        public Task<ModifyPictureResponse> ModifyPicture(ModifyPictureRequest req)
        {
            return InternalRequestAsync<ModifyPictureResponse>(req, "ModifyPicture");
        }

        /// <summary>
        /// 如果您需要在 [云端混流转码](https://cloud.tencent.com/document/product/647/16827) 时频繁修改自定义背景图或水印素材，可通过此接口修改已上传的图片。无需频繁修改图片素材的场景，建议直接在 [控制台 > 应用管理 > 素材管理](https://cloud.tencent.com/document/product/647/50769) 中操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyPictureRequest"/></param>
        /// <returns><see cref="ModifyPictureResponse"/></returns>
        public ModifyPictureResponse ModifyPictureSync(ModifyPictureRequest req)
        {
            return InternalRequestAsync<ModifyPictureResponse>(req, "ModifyPicture")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 传入音频base64串，注册声纹信息，返回声纹ID
        /// </summary>
        /// <param name="req"><see cref="RegisterVoicePrintRequest"/></param>
        /// <returns><see cref="RegisterVoicePrintResponse"/></returns>
        public Task<RegisterVoicePrintResponse> RegisterVoicePrint(RegisterVoicePrintRequest req)
        {
            return InternalRequestAsync<RegisterVoicePrintResponse>(req, "RegisterVoicePrint");
        }

        /// <summary>
        /// 传入音频base64串，注册声纹信息，返回声纹ID
        /// </summary>
        /// <param name="req"><see cref="RegisterVoicePrintRequest"/></param>
        /// <returns><see cref="RegisterVoicePrintResponse"/></returns>
        public RegisterVoicePrintResponse RegisterVoicePrintSync(RegisterVoicePrintRequest req)
        {
            return InternalRequestAsync<RegisterVoicePrintResponse>(req, "RegisterVoicePrint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：将用户从房间移出，适用于主播/房主/管理员踢人等场景。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="RemoveUserRequest"/></param>
        /// <returns><see cref="RemoveUserResponse"/></returns>
        public Task<RemoveUserResponse> RemoveUser(RemoveUserRequest req)
        {
            return InternalRequestAsync<RemoveUserResponse>(req, "RemoveUser");
        }

        /// <summary>
        /// 接口说明：将用户从房间移出，适用于主播/房主/管理员踢人等场景。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="RemoveUserRequest"/></param>
        /// <returns><see cref="RemoveUserResponse"/></returns>
        public RemoveUserResponse RemoveUserSync(RemoveUserRequest req)
        {
            return InternalRequestAsync<RemoveUserResponse>(req, "RemoveUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：将用户从房间移出，适用于主播/房主/管理员踢人等场景。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="RemoveUserByStrRoomIdRequest"/></param>
        /// <returns><see cref="RemoveUserByStrRoomIdResponse"/></returns>
        public Task<RemoveUserByStrRoomIdResponse> RemoveUserByStrRoomId(RemoveUserByStrRoomIdRequest req)
        {
            return InternalRequestAsync<RemoveUserByStrRoomIdResponse>(req, "RemoveUserByStrRoomId");
        }

        /// <summary>
        /// 接口说明：将用户从房间移出，适用于主播/房主/管理员踢人等场景。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="RemoveUserByStrRoomIdRequest"/></param>
        /// <returns><see cref="RemoveUserByStrRoomIdResponse"/></returns>
        public RemoveUserByStrRoomIdResponse RemoveUserByStrRoomIdSync(RemoveUserByStrRoomIdRequest req)
        {
            return InternalRequestAsync<RemoveUserByStrRoomIdResponse>(req, "RemoveUserByStrRoomId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动AI对话任务，AI通道机器人进入TRTC房间，与房间内指定的成员进行AI对话，适用于智能客服，AI口语教师等场景
        /// 
        /// TRTC AI对话功能内置语音转文本能力，同时提供通道服务，即客户可灵活指定第三方AI模型（LLM）服务和文本转音频（TTS)服务，更多[功能说明](https://cloud.tencent.com/document/product/647/108901)。
        /// </summary>
        /// <param name="req"><see cref="StartAIConversationRequest"/></param>
        /// <returns><see cref="StartAIConversationResponse"/></returns>
        public Task<StartAIConversationResponse> StartAIConversation(StartAIConversationRequest req)
        {
            return InternalRequestAsync<StartAIConversationResponse>(req, "StartAIConversation");
        }

        /// <summary>
        /// 启动AI对话任务，AI通道机器人进入TRTC房间，与房间内指定的成员进行AI对话，适用于智能客服，AI口语教师等场景
        /// 
        /// TRTC AI对话功能内置语音转文本能力，同时提供通道服务，即客户可灵活指定第三方AI模型（LLM）服务和文本转音频（TTS)服务，更多[功能说明](https://cloud.tencent.com/document/product/647/108901)。
        /// </summary>
        /// <param name="req"><see cref="StartAIConversationRequest"/></param>
        /// <returns><see cref="StartAIConversationResponse"/></returns>
        public StartAIConversationResponse StartAIConversationSync(StartAIConversationRequest req)
        {
            return InternalRequestAsync<StartAIConversationResponse>(req, "StartAIConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动转录机器人，后台会通过机器人拉流进行实时进行语音识别并下发字幕和转录消息。
        /// 转录机器人支持两种拉流方式，通过TranscriptionMode字段控制：
        /// - 拉取全房间的流。
        /// - 拉取特定用户的流。
        /// 
        /// 服务端通过TRTC的自定义消息实时下发字幕以及转录消息，CmdId固定是1。客户端只需监听自定义消息的回调即可，比如[c++回调](https://cloud.tencent.com/document/product/647/79637#4cd82f4edb24992a15a25187089e1565)。其他客户端比如安卓、Web等同样可在该链接处找到。
        /// 
        /// 
        /// **注意：**
        /// TranscriptionMode为0时，需要保证一个房间内只发起一个任务，如果发起多个任务，则机器人之间会相互订阅，除非主动停止任务，否则只有10小时后任务才会超时退出，这种情况下建议填写SessionId，保证后续重复发起的任务失败。
        /// </summary>
        /// <param name="req"><see cref="StartAITranscriptionRequest"/></param>
        /// <returns><see cref="StartAITranscriptionResponse"/></returns>
        public Task<StartAITranscriptionResponse> StartAITranscription(StartAITranscriptionRequest req)
        {
            return InternalRequestAsync<StartAITranscriptionResponse>(req, "StartAITranscription");
        }

        /// <summary>
        /// 启动转录机器人，后台会通过机器人拉流进行实时进行语音识别并下发字幕和转录消息。
        /// 转录机器人支持两种拉流方式，通过TranscriptionMode字段控制：
        /// - 拉取全房间的流。
        /// - 拉取特定用户的流。
        /// 
        /// 服务端通过TRTC的自定义消息实时下发字幕以及转录消息，CmdId固定是1。客户端只需监听自定义消息的回调即可，比如[c++回调](https://cloud.tencent.com/document/product/647/79637#4cd82f4edb24992a15a25187089e1565)。其他客户端比如安卓、Web等同样可在该链接处找到。
        /// 
        /// 
        /// **注意：**
        /// TranscriptionMode为0时，需要保证一个房间内只发起一个任务，如果发起多个任务，则机器人之间会相互订阅，除非主动停止任务，否则只有10小时后任务才会超时退出，这种情况下建议填写SessionId，保证后续重复发起的任务失败。
        /// </summary>
        /// <param name="req"><see cref="StartAITranscriptionRequest"/></param>
        /// <returns><see cref="StartAITranscriptionResponse"/></returns>
        public StartAITranscriptionResponse StartAITranscriptionSync(StartAITranscriptionRequest req)
        {
            return InternalRequestAsync<StartAITranscriptionResponse>(req, "StartAITranscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// - 自定义模板：适用于在混流中指定用户的画面位置，或者预设视频画面位置的场景。当预设位置指定用户时，排版引擎会为该用户预留位置；当预设位置未指定用户时，排版引擎会根据进房间顺序自动填充。预设位置填满时，不再混合其他用户的画面和声音。自定义模板启用占位图功能时（LayoutParams中的PlaceHolderMode设置成1），在预设位置的用户没有上行视频时可显示对应的占位图（PlaceImageId）。
        /// 
        /// 注意：
        /// 1、**混流转码为收费功能，调用接口将产生云端混流转码费用，详见[云端混流转码计费说明](https://cloud.tencent.com/document/product/647/49446)。**
        /// 2、2020年1月9号及以后创建的应用才能直接调用此接口。2020年1月9日之前创建的应用默认使用云直播的云端混流，如需切换至MCU混流，请[提交工单](https://console.cloud.tencent.com/workorder/category)寻求帮助。
        /// 3、客户端混流和服务端混流不能混用。
        /// </summary>
        /// <param name="req"><see cref="StartMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StartMCUMixTranscodeResponse"/></returns>
        public Task<StartMCUMixTranscodeResponse> StartMCUMixTranscode(StartMCUMixTranscodeRequest req)
        {
            return InternalRequestAsync<StartMCUMixTranscodeResponse>(req, "StartMCUMixTranscode");
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
        /// - 自定义模板：适用于在混流中指定用户的画面位置，或者预设视频画面位置的场景。当预设位置指定用户时，排版引擎会为该用户预留位置；当预设位置未指定用户时，排版引擎会根据进房间顺序自动填充。预设位置填满时，不再混合其他用户的画面和声音。自定义模板启用占位图功能时（LayoutParams中的PlaceHolderMode设置成1），在预设位置的用户没有上行视频时可显示对应的占位图（PlaceImageId）。
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
            return InternalRequestAsync<StartMCUMixTranscodeResponse>(req, "StartMCUMixTranscode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// - 自定义模板：适用于在混流中指定用户的画面位置，或者预设视频画面位置的场景。当预设位置指定用户时，排版引擎会为该用户预留位置；当预设位置未指定用户时，排版引擎会根据进房间顺序自动填充。预设位置填满时，不再混合其他用户的画面和声音。自定义模板启用占位图功能时（LayoutParams中的PlaceHolderMode设置成1），在预设位置的用户没有上行视频时可显示对应的占位图（PlaceImageId）。
        /// 
        /// 注意：
        /// 1、**混流转码为收费功能，调用接口将产生云端混流转码费用，详见[云端混流转码计费说明](https://cloud.tencent.com/document/product/647/49446)。**
        /// 2、2020年1月9号及以后创建的应用才能直接调用此接口。2020年1月9日之前创建的应用默认使用云直播的云端混流，如需切换至MCU混流，请[提交工单](https://console.cloud.tencent.com/workorder/category)寻求帮助。
        /// 3、客户端混流和服务端混流不能混用。
        /// </summary>
        /// <param name="req"><see cref="StartMCUMixTranscodeByStrRoomIdRequest"/></param>
        /// <returns><see cref="StartMCUMixTranscodeByStrRoomIdResponse"/></returns>
        public Task<StartMCUMixTranscodeByStrRoomIdResponse> StartMCUMixTranscodeByStrRoomId(StartMCUMixTranscodeByStrRoomIdRequest req)
        {
            return InternalRequestAsync<StartMCUMixTranscodeByStrRoomIdResponse>(req, "StartMCUMixTranscodeByStrRoomId");
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
        /// - 自定义模板：适用于在混流中指定用户的画面位置，或者预设视频画面位置的场景。当预设位置指定用户时，排版引擎会为该用户预留位置；当预设位置未指定用户时，排版引擎会根据进房间顺序自动填充。预设位置填满时，不再混合其他用户的画面和声音。自定义模板启用占位图功能时（LayoutParams中的PlaceHolderMode设置成1），在预设位置的用户没有上行视频时可显示对应的占位图（PlaceImageId）。
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
            return InternalRequestAsync<StartMCUMixTranscodeByStrRoomIdResponse>(req, "StartMCUMixTranscodeByStrRoomId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：  
        /// 启动一个混流转推任务，将  TRTC 房间的多路音视频流混成一路音视频流，编码后推到直播 CDN 或者回推到 TRTC 房间。也支持不转码直接转推 TRTC 房间的单路流。启动成功后，会返回一个 SdkAppid 维度唯一的任务 Id（TaskId）。您需要保存该 TaskId，后续需要依赖此 TaskId 更新和结束任务。可以参考文档： [功能说明](https://cloud.tencent.com/document/product/647/84721#b9a855f4-e38c-4616-9b07-fc44e0e8282a) 和 [常见问题](https://cloud.tencent.com/document/product/647/62620)
        /// 
        /// 注意：
        /// 您可以在控制台开通旁路转推回调功能，对转推 CDN 状态的事件进行监控，回调请参考文档：[旁路转推回调说明](https://cloud.tencent.com/document/product/647/88552)  
        /// 您发起混流转推任务时，可能会产生如下费用：  
        /// MCU 混流转码费用，请参考文档：[云端混流转码计费说明](https://cloud.tencent.com/document/product/647/49446)  
        /// 转推非腾讯云 CDN 费用，请参考文档：[云端转推计费说明](https://cloud.tencent.com/document/product/647/82155)
        /// </summary>
        /// <param name="req"><see cref="StartPublishCdnStreamRequest"/></param>
        /// <returns><see cref="StartPublishCdnStreamResponse"/></returns>
        public Task<StartPublishCdnStreamResponse> StartPublishCdnStream(StartPublishCdnStreamRequest req)
        {
            return InternalRequestAsync<StartPublishCdnStreamResponse>(req, "StartPublishCdnStream");
        }

        /// <summary>
        /// 接口说明：  
        /// 启动一个混流转推任务，将  TRTC 房间的多路音视频流混成一路音视频流，编码后推到直播 CDN 或者回推到 TRTC 房间。也支持不转码直接转推 TRTC 房间的单路流。启动成功后，会返回一个 SdkAppid 维度唯一的任务 Id（TaskId）。您需要保存该 TaskId，后续需要依赖此 TaskId 更新和结束任务。可以参考文档： [功能说明](https://cloud.tencent.com/document/product/647/84721#b9a855f4-e38c-4616-9b07-fc44e0e8282a) 和 [常见问题](https://cloud.tencent.com/document/product/647/62620)
        /// 
        /// 注意：
        /// 您可以在控制台开通旁路转推回调功能，对转推 CDN 状态的事件进行监控，回调请参考文档：[旁路转推回调说明](https://cloud.tencent.com/document/product/647/88552)  
        /// 您发起混流转推任务时，可能会产生如下费用：  
        /// MCU 混流转码费用，请参考文档：[云端混流转码计费说明](https://cloud.tencent.com/document/product/647/49446)  
        /// 转推非腾讯云 CDN 费用，请参考文档：[云端转推计费说明](https://cloud.tencent.com/document/product/647/82155)
        /// </summary>
        /// <param name="req"><see cref="StartPublishCdnStreamRequest"/></param>
        /// <returns><see cref="StartPublishCdnStreamResponse"/></returns>
        public StartPublishCdnStreamResponse StartPublishCdnStreamSync(StartPublishCdnStreamRequest req)
        {
            return InternalRequestAsync<StartPublishCdnStreamResponse>(req, "StartPublishCdnStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将一个在线媒体流推到TRTC房间，更多功能说明见[输入媒体流进房](https://cloud.tencent.com/document/product/647/102957#50940aad-d90f-4473-9f46-d5dd46917653)。
        /// 使用输入在线媒体流功能需先订阅 [尊享版或旗舰版套餐包](https://cloud.tencent.com/document/product/647/85386) 解锁能力位。
        /// </summary>
        /// <param name="req"><see cref="StartStreamIngestRequest"/></param>
        /// <returns><see cref="StartStreamIngestResponse"/></returns>
        public Task<StartStreamIngestResponse> StartStreamIngest(StartStreamIngestRequest req)
        {
            return InternalRequestAsync<StartStreamIngestResponse>(req, "StartStreamIngest");
        }

        /// <summary>
        /// 将一个在线媒体流推到TRTC房间，更多功能说明见[输入媒体流进房](https://cloud.tencent.com/document/product/647/102957#50940aad-d90f-4473-9f46-d5dd46917653)。
        /// 使用输入在线媒体流功能需先订阅 [尊享版或旗舰版套餐包](https://cloud.tencent.com/document/product/647/85386) 解锁能力位。
        /// </summary>
        /// <param name="req"><see cref="StartStreamIngestRequest"/></param>
        /// <returns><see cref="StartStreamIngestResponse"/></returns>
        public StartStreamIngestResponse StartStreamIngestSync(StartStreamIngestRequest req)
        {
            return InternalRequestAsync<StartStreamIngestResponse>(req, "StartStreamIngest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过此接口可以发起 WEB 页面录制任务，在接口参数中指定录制 URL，录制分辨率，录制结果存储等参数。
        /// 因为参数或API逻辑问题会立即返回结果。而因为页面问题，如页面无法访问，会在回调中返回结果，请关注。
        /// </summary>
        /// <param name="req"><see cref="StartWebRecordRequest"/></param>
        /// <returns><see cref="StartWebRecordResponse"/></returns>
        public Task<StartWebRecordResponse> StartWebRecord(StartWebRecordRequest req)
        {
            return InternalRequestAsync<StartWebRecordResponse>(req, "StartWebRecord");
        }

        /// <summary>
        /// 通过此接口可以发起 WEB 页面录制任务，在接口参数中指定录制 URL，录制分辨率，录制结果存储等参数。
        /// 因为参数或API逻辑问题会立即返回结果。而因为页面问题，如页面无法访问，会在回调中返回结果，请关注。
        /// </summary>
        /// <param name="req"><see cref="StartWebRecordRequest"/></param>
        /// <returns><see cref="StartWebRecordResponse"/></returns>
        public StartWebRecordResponse StartWebRecordSync(StartWebRecordRequest req)
        {
            return InternalRequestAsync<StartWebRecordResponse>(req, "StartWebRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止AI对话任务
        /// </summary>
        /// <param name="req"><see cref="StopAIConversationRequest"/></param>
        /// <returns><see cref="StopAIConversationResponse"/></returns>
        public Task<StopAIConversationResponse> StopAIConversation(StopAIConversationRequest req)
        {
            return InternalRequestAsync<StopAIConversationResponse>(req, "StopAIConversation");
        }

        /// <summary>
        /// 停止AI对话任务
        /// </summary>
        /// <param name="req"><see cref="StopAIConversationRequest"/></param>
        /// <returns><see cref="StopAIConversationResponse"/></returns>
        public StopAIConversationResponse StopAIConversationSync(StopAIConversationRequest req)
        {
            return InternalRequestAsync<StopAIConversationResponse>(req, "StopAIConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止AI转录任务。
        /// </summary>
        /// <param name="req"><see cref="StopAITranscriptionRequest"/></param>
        /// <returns><see cref="StopAITranscriptionResponse"/></returns>
        public Task<StopAITranscriptionResponse> StopAITranscription(StopAITranscriptionRequest req)
        {
            return InternalRequestAsync<StopAITranscriptionResponse>(req, "StopAITranscription");
        }

        /// <summary>
        /// 停止AI转录任务。
        /// </summary>
        /// <param name="req"><see cref="StopAITranscriptionRequest"/></param>
        /// <returns><see cref="StopAITranscriptionResponse"/></returns>
        public StopAITranscriptionResponse StopAITranscriptionSync(StopAITranscriptionRequest req)
        {
            return InternalRequestAsync<StopAITranscriptionResponse>(req, "StopAITranscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：结束云端混流
        /// </summary>
        /// <param name="req"><see cref="StopMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StopMCUMixTranscodeResponse"/></returns>
        public Task<StopMCUMixTranscodeResponse> StopMCUMixTranscode(StopMCUMixTranscodeRequest req)
        {
            return InternalRequestAsync<StopMCUMixTranscodeResponse>(req, "StopMCUMixTranscode");
        }

        /// <summary>
        /// 接口说明：结束云端混流
        /// </summary>
        /// <param name="req"><see cref="StopMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StopMCUMixTranscodeResponse"/></returns>
        public StopMCUMixTranscodeResponse StopMCUMixTranscodeSync(StopMCUMixTranscodeRequest req)
        {
            return InternalRequestAsync<StopMCUMixTranscodeResponse>(req, "StopMCUMixTranscode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：结束云端混流
        /// </summary>
        /// <param name="req"><see cref="StopMCUMixTranscodeByStrRoomIdRequest"/></param>
        /// <returns><see cref="StopMCUMixTranscodeByStrRoomIdResponse"/></returns>
        public Task<StopMCUMixTranscodeByStrRoomIdResponse> StopMCUMixTranscodeByStrRoomId(StopMCUMixTranscodeByStrRoomIdRequest req)
        {
            return InternalRequestAsync<StopMCUMixTranscodeByStrRoomIdResponse>(req, "StopMCUMixTranscodeByStrRoomId");
        }

        /// <summary>
        /// 接口说明：结束云端混流
        /// </summary>
        /// <param name="req"><see cref="StopMCUMixTranscodeByStrRoomIdRequest"/></param>
        /// <returns><see cref="StopMCUMixTranscodeByStrRoomIdResponse"/></returns>
        public StopMCUMixTranscodeByStrRoomIdResponse StopMCUMixTranscodeByStrRoomIdSync(StopMCUMixTranscodeByStrRoomIdRequest req)
        {
            return InternalRequestAsync<StopMCUMixTranscodeByStrRoomIdResponse>(req, "StopMCUMixTranscodeByStrRoomId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：
        /// 停止指定的混流转推任务。如果没有调用 Stop 接口停止任务，所有参与混流转推的主播离开 TRTC 房间超过 AgentParams.MaxIdleTime 设置的时间后，任务也会自动停止。
        /// </summary>
        /// <param name="req"><see cref="StopPublishCdnStreamRequest"/></param>
        /// <returns><see cref="StopPublishCdnStreamResponse"/></returns>
        public Task<StopPublishCdnStreamResponse> StopPublishCdnStream(StopPublishCdnStreamRequest req)
        {
            return InternalRequestAsync<StopPublishCdnStreamResponse>(req, "StopPublishCdnStream");
        }

        /// <summary>
        /// 接口说明：
        /// 停止指定的混流转推任务。如果没有调用 Stop 接口停止任务，所有参与混流转推的主播离开 TRTC 房间超过 AgentParams.MaxIdleTime 设置的时间后，任务也会自动停止。
        /// </summary>
        /// <param name="req"><see cref="StopPublishCdnStreamRequest"/></param>
        /// <returns><see cref="StopPublishCdnStreamResponse"/></returns>
        public StopPublishCdnStreamResponse StopPublishCdnStreamSync(StopPublishCdnStreamRequest req)
        {
            return InternalRequestAsync<StopPublishCdnStreamResponse>(req, "StopPublishCdnStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止一个输入在线媒体流任务。
        /// </summary>
        /// <param name="req"><see cref="StopStreamIngestRequest"/></param>
        /// <returns><see cref="StopStreamIngestResponse"/></returns>
        public Task<StopStreamIngestResponse> StopStreamIngest(StopStreamIngestRequest req)
        {
            return InternalRequestAsync<StopStreamIngestResponse>(req, "StopStreamIngest");
        }

        /// <summary>
        /// 停止一个输入在线媒体流任务。
        /// </summary>
        /// <param name="req"><see cref="StopStreamIngestRequest"/></param>
        /// <returns><see cref="StopStreamIngestResponse"/></returns>
        public StopStreamIngestResponse StopStreamIngestSync(StopStreamIngestRequest req)
        {
            return InternalRequestAsync<StopStreamIngestResponse>(req, "StopStreamIngest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止页面录制任务
        /// </summary>
        /// <param name="req"><see cref="StopWebRecordRequest"/></param>
        /// <returns><see cref="StopWebRecordResponse"/></returns>
        public Task<StopWebRecordResponse> StopWebRecord(StopWebRecordRequest req)
        {
            return InternalRequestAsync<StopWebRecordResponse>(req, "StopWebRecord");
        }

        /// <summary>
        /// 停止页面录制任务
        /// </summary>
        /// <param name="req"><see cref="StopWebRecordRequest"/></param>
        /// <returns><see cref="StopWebRecordResponse"/></returns>
        public StopWebRecordResponse StopWebRecordSync(StopWebRecordRequest req)
        {
            return InternalRequestAsync<StopWebRecordResponse>(req, "StopWebRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新AIConversation参数
        /// </summary>
        /// <param name="req"><see cref="UpdateAIConversationRequest"/></param>
        /// <returns><see cref="UpdateAIConversationResponse"/></returns>
        public Task<UpdateAIConversationResponse> UpdateAIConversation(UpdateAIConversationRequest req)
        {
            return InternalRequestAsync<UpdateAIConversationResponse>(req, "UpdateAIConversation");
        }

        /// <summary>
        /// 更新AIConversation参数
        /// </summary>
        /// <param name="req"><see cref="UpdateAIConversationRequest"/></param>
        /// <returns><see cref="UpdateAIConversationResponse"/></returns>
        public UpdateAIConversationResponse UpdateAIConversationSync(UpdateAIConversationRequest req)
        {
            return InternalRequestAsync<UpdateAIConversationResponse>(req, "UpdateAIConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口说明：
        /// 成功发起混流转推后，可以使用此接口来更新任务。仅在任务进行时有效，任务退出后更新将会返回错误。更新操作为增量更新模式。
        /// 注意：为了保障推流的稳定性，更新不支持任务在纯音频、音视频、纯视频之间进行切换。
        /// </summary>
        /// <param name="req"><see cref="UpdatePublishCdnStreamRequest"/></param>
        /// <returns><see cref="UpdatePublishCdnStreamResponse"/></returns>
        public Task<UpdatePublishCdnStreamResponse> UpdatePublishCdnStream(UpdatePublishCdnStreamRequest req)
        {
            return InternalRequestAsync<UpdatePublishCdnStreamResponse>(req, "UpdatePublishCdnStream");
        }

        /// <summary>
        /// 接口说明：
        /// 成功发起混流转推后，可以使用此接口来更新任务。仅在任务进行时有效，任务退出后更新将会返回错误。更新操作为增量更新模式。
        /// 注意：为了保障推流的稳定性，更新不支持任务在纯音频、音视频、纯视频之间进行切换。
        /// </summary>
        /// <param name="req"><see cref="UpdatePublishCdnStreamRequest"/></param>
        /// <returns><see cref="UpdatePublishCdnStreamResponse"/></returns>
        public UpdatePublishCdnStreamResponse UpdatePublishCdnStreamSync(UpdatePublishCdnStreamRequest req)
        {
            return InternalRequestAsync<UpdatePublishCdnStreamResponse>(req, "UpdatePublishCdnStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新输入在线媒体流任务的StreamUrl
        /// </summary>
        /// <param name="req"><see cref="UpdateStreamIngestRequest"/></param>
        /// <returns><see cref="UpdateStreamIngestResponse"/></returns>
        public Task<UpdateStreamIngestResponse> UpdateStreamIngest(UpdateStreamIngestRequest req)
        {
            return InternalRequestAsync<UpdateStreamIngestResponse>(req, "UpdateStreamIngest");
        }

        /// <summary>
        /// 更新输入在线媒体流任务的StreamUrl
        /// </summary>
        /// <param name="req"><see cref="UpdateStreamIngestRequest"/></param>
        /// <returns><see cref="UpdateStreamIngestResponse"/></returns>
        public UpdateStreamIngestResponse UpdateStreamIngestSync(UpdateStreamIngestRequest req)
        {
            return InternalRequestAsync<UpdateStreamIngestResponse>(req, "UpdateStreamIngest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 传入声纹ID以及对应音频信息，更新对应声纹信息
        /// </summary>
        /// <param name="req"><see cref="UpdateVoicePrintRequest"/></param>
        /// <returns><see cref="UpdateVoicePrintResponse"/></returns>
        public Task<UpdateVoicePrintResponse> UpdateVoicePrint(UpdateVoicePrintRequest req)
        {
            return InternalRequestAsync<UpdateVoicePrintResponse>(req, "UpdateVoicePrint");
        }

        /// <summary>
        /// 传入声纹ID以及对应音频信息，更新对应声纹信息
        /// </summary>
        /// <param name="req"><see cref="UpdateVoicePrintRequest"/></param>
        /// <returns><see cref="UpdateVoicePrintResponse"/></returns>
        public UpdateVoicePrintResponse UpdateVoicePrintSync(UpdateVoicePrintRequest req)
        {
            return InternalRequestAsync<UpdateVoicePrintResponse>(req, "UpdateVoicePrint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
