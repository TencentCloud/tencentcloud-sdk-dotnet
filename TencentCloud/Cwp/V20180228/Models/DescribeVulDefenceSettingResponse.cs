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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulDefenceSettingResponse : AbstractModel
    {
        
        /// <summary>
        /// 防御开关，0 关闭 1 开启
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 影响范围：1 全网旗舰版主机，0 quuid列表主机
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }

        /// <summary>
        /// 影响主机quuid列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// 当前旗舰版主机数量
        /// </summary>
        [JsonProperty("FlagshipCount")]
        public ulong? FlagshipCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamSimple(map, prefix + "FlagshipCount", this.FlagshipCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

