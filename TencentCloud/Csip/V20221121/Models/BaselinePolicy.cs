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

    public class BaselinePolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>周期扫描配置（开关、间隔类型、扫描时段等）。</p>
        /// </summary>
        [JsonProperty("CycleScanConf")]
        public CycleScanConf CycleScanConf{ get; set; }

        /// <summary>
        /// <p>检测资产大类，区分主机基线与容器集群基线。取值：</p><ul><li>HOST：主机</li><li>CLUSTER：容器集群</li></ul>
        /// </summary>
        [JsonProperty("CheckAssetType")]
        public string CheckAssetType{ get; set; }

        /// <summary>
        /// <p>是否在系统新增内置检测项时自动加入本策略。true 自动加入，false 不加入。</p>
        /// </summary>
        [JsonProperty("AutoSyncItem")]
        public bool? AutoSyncItem{ get; set; }

        /// <summary>
        /// <p>基线策略类型。取值：</p><ul><li>SYSTEM：系统策略（CSIP 内置）</li><li>SELF：用户自定义策略</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>策略名称（自定义策略由用户填写，系统策略为内置分类名）。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>主机生效范围。取值：</p><ul><li>ALL：全部主机（可配合 ConfHostExcludeList 剔除）</li><li>TAG_MATCH：按标签匹配，配合 ConfHostTagValue</li><li>PICK：仅在 ConfHostIncludeList 指定的主机生效</li><li>NONE：未配置</li></ul>
        /// </summary>
        [JsonProperty("ConfHostType")]
        public string ConfHostType{ get; set; }

        /// <summary>
        /// <p>主机 InstanceID 白名单，在 ConfHostType=PICK / TAG_MATCH 时使用。</p>
        /// </summary>
        [JsonProperty("ConfHostIncludeList")]
        public string[] ConfHostIncludeList{ get; set; }

        /// <summary>
        /// <p>主机 InstanceID 剔除名单，在 ConfHostType=ALL 时使用。</p>
        /// </summary>
        [JsonProperty("ConfHostExcludeList")]
        public string[] ConfHostExcludeList{ get; set; }

        /// <summary>
        /// <p>策略启用状态。0 停用，1 启用；停用后该策略不参与扫描与统计。</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>集群生效范围。取值：</p><ul><li>ALL：全部集群（可配合 ConfClusterExcludeList 剔除）</li><li>PICK：仅在 ConfClusterIncludeList 指定的集群生效</li><li>NONE：未配置</li></ul>
        /// </summary>
        [JsonProperty("ConfClusterType")]
        public string ConfClusterType{ get; set; }

        /// <summary>
        /// <p>集群 ID 白名单，在 ConfClusterType=PICK 时使用。</p>
        /// </summary>
        [JsonProperty("ConfClusterIncludeList")]
        public string[] ConfClusterIncludeList{ get; set; }

        /// <summary>
        /// <p>集群 ID 剔除名单，在 ConfClusterType=ALL 时使用。</p>
        /// </summary>
        [JsonProperty("ConfClusterExcludeList")]
        public string[] ConfClusterExcludeList{ get; set; }

        /// <summary>
        /// <p>系统分类 / 子分类 / 检测项的命中配置（仅系统策略生效）。</p>
        /// </summary>
        [JsonProperty("CategoryConf")]
        public BaselinePolicySystemCategoryConf[] CategoryConf{ get; set; }

        /// <summary>
        /// <p>自定义检测项的取值配置列表（在系统检测项基础上覆盖判定值）。</p>
        /// </summary>
        [JsonProperty("CustomItemConf")]
        public BaselineCustomItemConf[] CustomItemConf{ get; set; }

        /// <summary>
        /// <p>策略所属租户 Appid。</p>
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// <p>基线策略 ID。</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>当前策略已配置的检测项数量。</p>
        /// </summary>
        [JsonProperty("ConfItemCount")]
        public ulong? ConfItemCount{ get; set; }

        /// <summary>
        /// <p>当前策略命中的主机数量。</p>
        /// </summary>
        [JsonProperty("ConfHostCount")]
        public ulong? ConfHostCount{ get; set; }

        /// <summary>
        /// <p>当前策略命中的集群数量。</p>
        /// </summary>
        [JsonProperty("ConfClusterCount")]
        public ulong? ConfClusterCount{ get; set; }

        /// <summary>
        /// <p>策略当前进行中的扫描主任务 ID；未在扫描时为 0。</p>
        /// </summary>
        [JsonProperty("ScanningTaskID")]
        public ulong? ScanningTaskID{ get; set; }

        /// <summary>
        /// <p>最近一次扫描完成时间（含手动 / 周期）。</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// <p>最近一次周期性扫描完成时间。</p>
        /// </summary>
        [JsonProperty("LatestCycleScanTime")]
        public string LatestCycleScanTime{ get; set; }

        /// <summary>
        /// <p>安全中心标签ID列表</p>
        /// </summary>
        [JsonProperty("TagIDList")]
        public ulong?[] TagIDList{ get; set; }

        /// <summary>
        /// <p>云标签列表</p>
        /// </summary>
        [JsonProperty("CloudTagList")]
        public string[] CloudTagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CycleScanConf.", this.CycleScanConf);
            this.SetParamSimple(map, prefix + "CheckAssetType", this.CheckAssetType);
            this.SetParamSimple(map, prefix + "AutoSyncItem", this.AutoSyncItem);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConfHostType", this.ConfHostType);
            this.SetParamArraySimple(map, prefix + "ConfHostIncludeList.", this.ConfHostIncludeList);
            this.SetParamArraySimple(map, prefix + "ConfHostExcludeList.", this.ConfHostExcludeList);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "ConfClusterType", this.ConfClusterType);
            this.SetParamArraySimple(map, prefix + "ConfClusterIncludeList.", this.ConfClusterIncludeList);
            this.SetParamArraySimple(map, prefix + "ConfClusterExcludeList.", this.ConfClusterExcludeList);
            this.SetParamArrayObj(map, prefix + "CategoryConf.", this.CategoryConf);
            this.SetParamArrayObj(map, prefix + "CustomItemConf.", this.CustomItemConf);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "ConfItemCount", this.ConfItemCount);
            this.SetParamSimple(map, prefix + "ConfHostCount", this.ConfHostCount);
            this.SetParamSimple(map, prefix + "ConfClusterCount", this.ConfClusterCount);
            this.SetParamSimple(map, prefix + "ScanningTaskID", this.ScanningTaskID);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "LatestCycleScanTime", this.LatestCycleScanTime);
            this.SetParamArraySimple(map, prefix + "TagIDList.", this.TagIDList);
            this.SetParamArraySimple(map, prefix + "CloudTagList.", this.CloudTagList);
        }
    }
}

