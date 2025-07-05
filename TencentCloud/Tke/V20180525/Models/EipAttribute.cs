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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EipAttribute : AbstractModel
    {
        
        /// <summary>
        /// 容器实例删除后，EIP是否释放。
        /// Never表示不释放，其他任意值（包括空字符串）表示释放。
        /// </summary>
        [JsonProperty("DeletePolicy")]
        public string DeletePolicy{ get; set; }

        /// <summary>
        /// EIP线路类型。默认值：BGP。
        /// 已开通静态单线IP白名单的用户，可选值：
        /// CMCC：中国移动
        /// CTCC：中国电信
        /// CUCC：中国联通
        /// 注意：仅部分地域支持静态单线IP。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// EIP出带宽上限，单位：Mbps。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeletePolicy", this.DeletePolicy);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
        }
    }
}

