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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulStoreListInfo : AbstractModel
    {
        
        /// <summary>
        /// 漏洞ID
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// 漏洞级别
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// cve编号
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// 1: web-cms漏洞 2:应用漏洞  4: Linux软件漏洞 5: Windows系统漏洞 0= 应急漏洞
        /// </summary>
        [JsonProperty("VulCategory")]
        public ulong? VulCategory{ get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonProperty("PublishDate")]
        public string PublishDate{ get; set; }

        /// <summary>
        /// 漏洞检测方法 0 - 版本比对, 1 - POC验证
        /// </summary>
        [JsonProperty("Method")]
        public ulong? Method{ get; set; }

        /// <summary>
        /// 漏洞攻击热度
        /// </summary>
        [JsonProperty("AttackLevel")]
        public ulong? AttackLevel{ get; set; }

        /// <summary>
        /// 漏洞是否支持自动修复
        /// 0-Windows/Linux均关闭; 1-Windows/Linux均打开; 2-仅Linux; 3-仅Windows
        /// </summary>
        [JsonProperty("FixSwitch")]
        public ulong? FixSwitch{ get; set; }

        /// <summary>
        /// 漏洞是否支持防御
        /// 0:不支持 1:支持
        /// </summary>
        [JsonProperty("SupportDefense")]
        public ulong? SupportDefense{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
            this.SetParamSimple(map, prefix + "PublishDate", this.PublishDate);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "AttackLevel", this.AttackLevel);
            this.SetParamSimple(map, prefix + "FixSwitch", this.FixSwitch);
            this.SetParamSimple(map, prefix + "SupportDefense", this.SupportDefense);
        }
    }
}

