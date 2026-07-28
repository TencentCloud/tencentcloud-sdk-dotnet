/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class CreateLiveStreamModerationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>TRTC的<a href="https://cloud.tencent.com/document/product/647/46351#sdkappid">SdkAppId</a>。</p>
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// <p>直播流输入源</p>
        /// </summary>
        [JsonProperty("Input")]
        public Input Input{ get; set; }

        /// <summary>
        /// <p>直播流ai理解审核参数</p>
        /// </summary>
        [JsonProperty("LiveModerationParams")]
        public LiveModerationParams LiveModerationParams{ get; set; }

        /// <summary>
        /// <p>业务自定义唯一标识，原样透传到回调</p><p>入参限制：长度限制60字符</p>
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// <p>额外信息透传结构体（房间/主播/业务自定义），原样回带到回调</p>
        /// </summary>
        [JsonProperty("SourceInfo")]
        public SourceInfo SourceInfo{ get; set; }

        /// <summary>
        /// <p>直播流ai理解转存文件存储参数</p>
        /// </summary>
        [JsonProperty("LiveModerationStorageParams")]
        public LiveModerationStorageParams LiveModerationStorageParams{ get; set; }

        /// <summary>
        /// <p>单路任务最大的生命周期</p><p>取值范围：[1, 72]</p><p>单位：小时</p><p>默认值：48</p>
        /// </summary>
        [JsonProperty("ResourceExpiredHour")]
        public ulong? ResourceExpiredHour{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamObj(map, prefix + "Input.", this.Input);
            this.SetParamObj(map, prefix + "LiveModerationParams.", this.LiveModerationParams);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamObj(map, prefix + "SourceInfo.", this.SourceInfo);
            this.SetParamObj(map, prefix + "LiveModerationStorageParams.", this.LiveModerationStorageParams);
            this.SetParamSimple(map, prefix + "ResourceExpiredHour", this.ResourceExpiredHour);
        }
    }
}

