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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOwnNumberApplyRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// SIP通道ID
        /// </summary>
        [JsonProperty("SipTrunkId")]
        public long? SipTrunkId{ get; set; }

        /// <summary>
        /// 线路相关参数
        /// </summary>
        [JsonProperty("DetailList")]
        public OwnNumberApplyDetailItem[] DetailList{ get; set; }

        /// <summary>
        /// 送号前缀
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "SipTrunkId", this.SipTrunkId);
            this.SetParamArrayObj(map, prefix + "DetailList.", this.DetailList);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
        }
    }
}

