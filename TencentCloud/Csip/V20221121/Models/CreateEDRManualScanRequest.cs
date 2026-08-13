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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEDRManualScanRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资产选择方式：all-全部资产/tag-按标签选择(仅主机)/direct-直接选择</p>
        /// </summary>
        [JsonProperty("AssetSelectionType")]
        public string AssetSelectionType{ get; set; }

        /// <summary>
        /// <p>检测模式：full-全盘检测/quick-快速检测/include-仅检测指定路径/exclude-排除指定路径</p>
        /// </summary>
        [JsonProperty("ScanType")]
        public string ScanType{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>直接选择的主机列表（AssetSelectionType=direct或all时使用）</p>
        /// </summary>
        [JsonProperty("InstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] InstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>剔除的主机列表（AssetSelectionType=all时使用）</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] ExcludeInstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>主机对应的标签ID</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public ulong?[] TagIds{ get; set; }

        /// <summary>
        /// <p>直接选择的集群列表</p>
        /// </summary>
        [JsonProperty("ClusterIDsWithAppId")]
        public ClusterWithAppIdItem[] ClusterIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>剔除的集群列表（AssetSelectionType=all时使用）</p>
        /// </summary>
        [JsonProperty("ExcludeClusterIDsWithAppId")]
        public ClusterWithAppIdItem[] ExcludeClusterIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>自选路径列表（ScanType=include或exclude时必填，最多100条）</p>
        /// </summary>
        [JsonProperty("CustomPaths")]
        public string[] CustomPaths{ get; set; }

        /// <summary>
        /// <p>超时时间（秒），上限7200</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>是否开启深度检测：0-否/1-是</p>
        /// </summary>
        [JsonProperty("EnableMemShellScan")]
        public long? EnableMemShellScan{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetSelectionType", this.AssetSelectionType);
            this.SetParamSimple(map, prefix + "ScanType", this.ScanType);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "InstanceIDsWithAppId.", this.InstanceIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeInstanceIDsWithAppId.", this.ExcludeInstanceIDsWithAppId);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArrayObj(map, prefix + "ClusterIDsWithAppId.", this.ClusterIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeClusterIDsWithAppId.", this.ExcludeClusterIDsWithAppId);
            this.SetParamArraySimple(map, prefix + "CustomPaths.", this.CustomPaths);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "EnableMemShellScan", this.EnableMemShellScan);
        }
    }
}

