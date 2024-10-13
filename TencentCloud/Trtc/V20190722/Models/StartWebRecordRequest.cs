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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartWebRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要录制的网页URL
        /// </summary>
        [JsonProperty("RecordUrl")]
        public string RecordUrl{ get; set; }

        /// <summary>
        /// 录制最大时长限制， 单位 s, 合法取值范围[1800, 36000], 默认 36000s(10 小时)
        /// </summary>
        [JsonProperty("MaxDurationLimit")]
        public ulong? MaxDurationLimit{ get; set; }

        /// <summary>
        /// 【必填】云存储相关的参数，目前支持腾讯云对象存储以及腾讯云云点播VOD，不支持第三方云存储；输出文件的存储格式仅支持hls或mp4
        /// </summary>
        [JsonProperty("StorageParams")]
        public StorageParams StorageParams{ get; set; }

        /// <summary>
        /// 页面录制视频参数
        /// </summary>
        [JsonProperty("WebRecordVideoParams")]
        public WebRecordVideoParams WebRecordVideoParams{ get; set; }

        /// <summary>
        /// 【必填】TRTC的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 当对重复任务敏感时，请关注此值： 为了避免任务在短时间内重复发起，导致任务重复
        /// 传入录制RecordId来标识此次任务， 小于32字节，若携带RecordId发起两次以上的开始录制请求，任务只会启动一个，第二个报错FailedOperation.TaskExist。注意StartWebRecord调用失败时而非FailedOperation.TaskExist错误，请更换RecordId重新发起。
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 若您想要推流到CDN，可以使用PublishCdnParams.N参数设置，支持最多同时推流到10个CDN地址。若转推地址是腾讯云CDN时，请将IsTencentCdn明确设置为1
        /// </summary>
        [JsonProperty("PublishCdnParams")]
        public McuPublishCdnParam[] PublishCdnParams{ get; set; }

        /// <summary>
        /// 录制页面资源加载的超时时间，单位：秒。默认值为 0 秒，该值需大于等于 0秒，且小于等于 60秒。录制页面未启用页面加载超时检测时，请勿设置此参数。
        /// </summary>
        [JsonProperty("ReadyTimeout")]
        public ulong? ReadyTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
            this.SetParamSimple(map, prefix + "MaxDurationLimit", this.MaxDurationLimit);
            this.SetParamObj(map, prefix + "StorageParams.", this.StorageParams);
            this.SetParamObj(map, prefix + "WebRecordVideoParams.", this.WebRecordVideoParams);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamArrayObj(map, prefix + "PublishCdnParams.", this.PublishCdnParams);
            this.SetParamSimple(map, prefix + "ReadyTimeout", this.ReadyTimeout);
        }
    }
}

