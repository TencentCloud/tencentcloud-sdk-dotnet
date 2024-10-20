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

namespace TencentCloud.Vrs.V20200824
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vrs.V20200824.Models;

   public class VrsClient : AbstractClient{

       private const string endpoint = "vrs.tencentcloudapi.com";
       private const string version = "2020-08-24";
       private const string sdkVersion = "SDK_NET_3.0.1109";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VrsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VrsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 声音复刻取消任务接口
        /// </summary>
        /// <param name="req"><see cref="CancelVRSTaskRequest"/></param>
        /// <returns><see cref="CancelVRSTaskResponse"/></returns>
        public Task<CancelVRSTaskResponse> CancelVRSTask(CancelVRSTaskRequest req)
        {
            return InternalRequestAsync<CancelVRSTaskResponse>(req, "CancelVRSTask");
        }

        /// <summary>
        /// 声音复刻取消任务接口
        /// </summary>
        /// <param name="req"><see cref="CancelVRSTaskRequest"/></param>
        /// <returns><see cref="CancelVRSTaskResponse"/></returns>
        public CancelVRSTaskResponse CancelVRSTaskSync(CancelVRSTaskRequest req)
        {
            return InternalRequestAsync<CancelVRSTaskResponse>(req, "CancelVRSTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口服务对提交音频进行声音复刻任务创建接口，异步返回复刻结果。
        /// • 请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// • 签名方法参考 公共参数 中签名方法v3。
        /// </summary>
        /// <param name="req"><see cref="CreateVRSTaskRequest"/></param>
        /// <returns><see cref="CreateVRSTaskResponse"/></returns>
        public Task<CreateVRSTaskResponse> CreateVRSTask(CreateVRSTaskRequest req)
        {
            return InternalRequestAsync<CreateVRSTaskResponse>(req, "CreateVRSTask");
        }

        /// <summary>
        /// 本接口服务对提交音频进行声音复刻任务创建接口，异步返回复刻结果。
        /// • 请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// • 签名方法参考 公共参数 中签名方法v3。
        /// </summary>
        /// <param name="req"><see cref="CreateVRSTaskRequest"/></param>
        /// <returns><see cref="CreateVRSTaskResponse"/></returns>
        public CreateVRSTaskResponse CreateVRSTaskSync(CreateVRSTaskRequest req)
        {
            return InternalRequestAsync<CreateVRSTaskResponse>(req, "CreateVRSTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在调用声音复刻创建任务请求接口后，有回调和轮询两种方式获取识别结果。
        /// • 当采用回调方式时，识别完成后会将结果通过 POST 请求的形式通知到用户在请求时填写的回调 URL，具体请参见 声音复刻结果回调 。
        /// • 当采用轮询方式时，需要主动提交任务ID来轮询识别结果，共有任务成功、等待、执行中和失败四种结果，具体信息请参见下文说明。
        /// • 请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// • 签名方法参考 公共参数 中签名方法v3。
        /// </summary>
        /// <param name="req"><see cref="DescribeVRSTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeVRSTaskStatusResponse"/></returns>
        public Task<DescribeVRSTaskStatusResponse> DescribeVRSTaskStatus(DescribeVRSTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeVRSTaskStatusResponse>(req, "DescribeVRSTaskStatus");
        }

        /// <summary>
        /// 在调用声音复刻创建任务请求接口后，有回调和轮询两种方式获取识别结果。
        /// • 当采用回调方式时，识别完成后会将结果通过 POST 请求的形式通知到用户在请求时填写的回调 URL，具体请参见 声音复刻结果回调 。
        /// • 当采用轮询方式时，需要主动提交任务ID来轮询识别结果，共有任务成功、等待、执行中和失败四种结果，具体信息请参见下文说明。
        /// • 请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// • 签名方法参考 公共参数 中签名方法v3。
        /// </summary>
        /// <param name="req"><see cref="DescribeVRSTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeVRSTaskStatusResponse"/></returns>
        public DescribeVRSTaskStatusResponse DescribeVRSTaskStatusSync(DescribeVRSTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeVRSTaskStatusResponse>(req, "DescribeVRSTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于检测音频的环境和音频质量。
        /// 对于一句话声音复刻，音频时长需大于3s，小于15s，文件大小不能超过2MB，音频需为单声道，位深为16bit。建议格式：wav、单声道、采样率48kHz或24kHz 
        /// • 请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// • 签名方法参考 公共参数 中签名方法v3。
        /// </summary>
        /// <param name="req"><see cref="DetectEnvAndSoundQualityRequest"/></param>
        /// <returns><see cref="DetectEnvAndSoundQualityResponse"/></returns>
        public Task<DetectEnvAndSoundQualityResponse> DetectEnvAndSoundQuality(DetectEnvAndSoundQualityRequest req)
        {
            return InternalRequestAsync<DetectEnvAndSoundQualityResponse>(req, "DetectEnvAndSoundQuality");
        }

        /// <summary>
        /// 本接口用于检测音频的环境和音频质量。
        /// 对于一句话声音复刻，音频时长需大于3s，小于15s，文件大小不能超过2MB，音频需为单声道，位深为16bit。建议格式：wav、单声道、采样率48kHz或24kHz 
        /// • 请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// • 签名方法参考 公共参数 中签名方法v3。
        /// </summary>
        /// <param name="req"><see cref="DetectEnvAndSoundQualityRequest"/></param>
        /// <returns><see cref="DetectEnvAndSoundQualityResponse"/></returns>
        public DetectEnvAndSoundQualityResponse DetectEnvAndSoundQualitySync(DetectEnvAndSoundQualityRequest req)
        {
            return InternalRequestAsync<DetectEnvAndSoundQualityResponse>(req, "DetectEnvAndSoundQuality")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载声音复刻离线模型
        /// </summary>
        /// <param name="req"><see cref="DownloadVRSModelRequest"/></param>
        /// <returns><see cref="DownloadVRSModelResponse"/></returns>
        public Task<DownloadVRSModelResponse> DownloadVRSModel(DownloadVRSModelRequest req)
        {
            return InternalRequestAsync<DownloadVRSModelResponse>(req, "DownloadVRSModel");
        }

        /// <summary>
        /// 下载声音复刻离线模型
        /// </summary>
        /// <param name="req"><see cref="DownloadVRSModelRequest"/></param>
        /// <returns><see cref="DownloadVRSModelResponse"/></returns>
        public DownloadVRSModelResponse DownloadVRSModelSync(DownloadVRSModelRequest req)
        {
            return InternalRequestAsync<DownloadVRSModelResponse>(req, "DownloadVRSModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取声音复刻训练文本信息。
        ///  请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// • 签名方法参考 公共参数 中签名方法v3。
        /// • 当复刻类型为一句话声音复刻时，生成的TextId有效期为7天，且在成功创建一次复刻任务后失效。
        /// </summary>
        /// <param name="req"><see cref="GetTrainingTextRequest"/></param>
        /// <returns><see cref="GetTrainingTextResponse"/></returns>
        public Task<GetTrainingTextResponse> GetTrainingText(GetTrainingTextRequest req)
        {
            return InternalRequestAsync<GetTrainingTextResponse>(req, "GetTrainingText");
        }

        /// <summary>
        /// 本接口用于获取声音复刻训练文本信息。
        ///  请求方法为 HTTP POST , Content-Type为"application/json; charset=utf-8"
        /// • 签名方法参考 公共参数 中签名方法v3。
        /// • 当复刻类型为一句话声音复刻时，生成的TextId有效期为7天，且在成功创建一次复刻任务后失效。
        /// </summary>
        /// <param name="req"><see cref="GetTrainingTextRequest"/></param>
        /// <returns><see cref="GetTrainingTextResponse"/></returns>
        public GetTrainingTextResponse GetTrainingTextSync(GetTrainingTextRequest req)
        {
            return InternalRequestAsync<GetTrainingTextResponse>(req, "GetTrainingText")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询复刻音色
        /// </summary>
        /// <param name="req"><see cref="GetVRSVoiceTypesRequest"/></param>
        /// <returns><see cref="GetVRSVoiceTypesResponse"/></returns>
        public Task<GetVRSVoiceTypesResponse> GetVRSVoiceTypes(GetVRSVoiceTypesRequest req)
        {
            return InternalRequestAsync<GetVRSVoiceTypesResponse>(req, "GetVRSVoiceTypes");
        }

        /// <summary>
        /// 查询复刻音色
        /// </summary>
        /// <param name="req"><see cref="GetVRSVoiceTypesRequest"/></param>
        /// <returns><see cref="GetVRSVoiceTypesResponse"/></returns>
        public GetVRSVoiceTypesResponse GetVRSVoiceTypesSync(GetVRSVoiceTypesRequest req)
        {
            return InternalRequestAsync<GetVRSVoiceTypesResponse>(req, "GetVRSVoiceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
