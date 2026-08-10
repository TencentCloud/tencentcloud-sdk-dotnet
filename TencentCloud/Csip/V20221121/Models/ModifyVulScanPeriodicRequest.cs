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

    public class ModifyVulScanPeriodicRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>周期扫描开关（0-关闭, 1-开启）</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>漏洞类型</p><p>枚举值：</p><ul><li>LINUX： Linux软件漏洞</li><li>WINDOWS： Windows系统补丁</li><li>WEB_CMS： Web-CMS漏洞</li><li>APPLICATION： 应用漏洞</li><li>EMERGENCY： 应急漏洞</li></ul>
        /// </summary>
        [JsonProperty("VulCategory")]
        public string[] VulCategory{ get; set; }

        /// <summary>
        /// <p>漏洞等级</p><p>枚举值：</p><ul><li>LOW： 低危</li><li>MEDIUM： 中危</li><li>HIGH： 高危</li><li>CRITICAL： 严重</li></ul>
        /// </summary>
        [JsonProperty("Level")]
        public string[] Level{ get; set; }

        /// <summary>
        /// <p>扫描方式（VersionCompare: 版本对比, POC: POC检测, VersionComparePOC: 版本对比+POC检测）</p>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>开始时间（09:00:00）</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间（18:00:00）</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>资产范围（0-全部资产，1-自选资产，2-剔除资产，3-自动资产匹配）</p>
        /// </summary>
        [JsonProperty("AssetRange")]
        public long? AssetRange{ get; set; }

        /// <summary>
        /// <p>周期扫描类型</p><p>枚举值：</p><ul><li>1： 每天</li><li>2： 每周</li><li>3： 每月</li></ul>
        /// </summary>
        [JsonProperty("CycleType")]
        public ulong? CycleType{ get; set; }

        /// <summary>
        /// <p>扫描超时时长</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>周期值</p><p>取值范围：[1, 31]</p><p>单位：周几或者每月几号</p>
        /// </summary>
        [JsonProperty("CycleValue")]
        public ulong?[] CycleValue{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>资产列表（instance_id列表）</p>
        /// </summary>
        [JsonProperty("AssetList")]
        public string[] AssetList{ get; set; }

        /// <summary>
        /// <p>是否运行被同步配置 0-不允许，1-允许</p>
        /// </summary>
        [JsonProperty("AllowSync")]
        public ulong? AllowSync{ get; set; }

        /// <summary>
        /// <p>管理员账号是否开启了自动同步配置开关 0-关闭，1-开启</p>
        /// </summary>
        [JsonProperty("EnableSync")]
        public ulong? EnableSync{ get; set; }

        /// <summary>
        /// <p>配置同步给哪些账号appid</p>
        /// </summary>
        [JsonProperty("SyncTo")]
        public ulong?[] SyncTo{ get; set; }

        /// <summary>
        /// <p>标签ID</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public ulong?[] TagIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "VulCategory.", this.VulCategory);
            this.SetParamArraySimple(map, prefix + "Level.", this.Level);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamArraySimple(map, prefix + "CycleValue.", this.CycleValue);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "AssetList.", this.AssetList);
            this.SetParamSimple(map, prefix + "AllowSync", this.AllowSync);
            this.SetParamSimple(map, prefix + "EnableSync", this.EnableSync);
            this.SetParamArraySimple(map, prefix + "SyncTo.", this.SyncTo);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
        }
    }
}

