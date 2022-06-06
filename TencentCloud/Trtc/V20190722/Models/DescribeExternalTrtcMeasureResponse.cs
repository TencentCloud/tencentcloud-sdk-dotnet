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

    public class DescribeExternalTrtcMeasureResponse : AbstractModel
    {
        
        /// <summary>
        /// 每个SdkAppId的时长使用信息
        /// </summary>
        [JsonProperty("SdkAppIdTrtrTimeUsages")]
        public SdkAppIdNewTrtcTimeUsage[] SdkAppIdTrtrTimeUsages{ get; set; }

        /// <summary>
        /// 主播的用量统计方式。取值"InRoomTime":房间时长,"SubscribeTime":"订阅时长","Bandwidth":带宽
        /// </summary>
        [JsonProperty("AnchorUsageMode")]
        public string AnchorUsageMode{ get; set; }

        /// <summary>
        /// 观众的用量统计方式。取值"InRoomTime":在房间时长,"SubscribeTime":"订阅时长","Bandwidth":带宽,"MergeWithAnchor":"不区分麦上麦下"
        /// </summary>
        [JsonProperty("AudienceUsageMode")]
        public string AudienceUsageMode{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SdkAppIdTrtrTimeUsages.", this.SdkAppIdTrtrTimeUsages);
            this.SetParamSimple(map, prefix + "AnchorUsageMode", this.AnchorUsageMode);
            this.SetParamSimple(map, prefix + "AudienceUsageMode", this.AudienceUsageMode);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

