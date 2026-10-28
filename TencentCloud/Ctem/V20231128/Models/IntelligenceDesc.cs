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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntelligenceDesc : AbstractModel
    {
        
        /// <summary>
        /// <p>情报ID</p>
        /// </summary>
        [JsonProperty("VulId")]
        public string VulId{ get; set; }

        /// <summary>
        /// <p>情报名称</p>
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// <p>情报概述</p>
        /// </summary>
        [JsonProperty("VulOverview")]
        public string VulOverview{ get; set; }

        /// <summary>
        /// <p>录入时间</p>
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// <p>漏洞风险等级 1：低风险，2：中风险，3：高风险</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// <p>关联组件</p>
        /// </summary>
        [JsonProperty("VulComponents")]
        public string VulComponents{ get; set; }

        /// <summary>
        /// <p>相关指纹数量</p>
        /// </summary>
        [JsonProperty("BannerCount")]
        public long? BannerCount{ get; set; }

        /// <summary>
        /// <p>漏洞资产数量</p>
        /// </summary>
        [JsonProperty("VulAssetCount")]
        public long? VulAssetCount{ get; set; }

        /// <summary>
        /// <p>最新任务状态:todo/doing/done，如果为空表示没有任务</p>
        /// </summary>
        [JsonProperty("LastTaskStatus")]
        public string LastTaskStatus{ get; set; }

        /// <summary>
        /// <p>任务id</p>
        /// </summary>
        [JsonProperty("LastTaskInstanceId")]
        public string LastTaskInstanceId{ get; set; }

        /// <summary>
        /// <p>xscan指纹插件id</p>
        /// </summary>
        [JsonProperty("XscanBannerPluginId")]
        public string XscanBannerPluginId{ get; set; }

        /// <summary>
        /// <p>xscan poc插件id</p>
        /// </summary>
        [JsonProperty("XscanPocPluginId")]
        public string XscanPocPluginId{ get; set; }

        /// <summary>
        /// <p>上一次扫描时间</p>
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "VulOverview", this.VulOverview);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamSimple(map, prefix + "VulComponents", this.VulComponents);
            this.SetParamSimple(map, prefix + "BannerCount", this.BannerCount);
            this.SetParamSimple(map, prefix + "VulAssetCount", this.VulAssetCount);
            this.SetParamSimple(map, prefix + "LastTaskStatus", this.LastTaskStatus);
            this.SetParamSimple(map, prefix + "LastTaskInstanceId", this.LastTaskInstanceId);
            this.SetParamSimple(map, prefix + "XscanBannerPluginId", this.XscanBannerPluginId);
            this.SetParamSimple(map, prefix + "XscanPocPluginId", this.XscanPocPluginId);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
        }
    }
}

