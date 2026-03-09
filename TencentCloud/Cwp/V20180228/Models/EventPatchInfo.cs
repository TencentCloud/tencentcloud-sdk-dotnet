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

    public class EventPatchInfo : AbstractModel
    {
        
        /// <summary>
        /// 补丁名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 补丁编号
        /// </summary>
        [JsonProperty("KbNo")]
        public string KbNo{ get; set; }

        /// <summary>
        /// 披露时间
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// 影响主机数量
        /// </summary>
        [JsonProperty("EffectHostCount")]
        public ulong? EffectHostCount{ get; set; }

        /// <summary>
        /// 关联的漏洞数
        /// </summary>
        [JsonProperty("RelateVulCount")]
        public ulong? RelateVulCount{ get; set; }

        /// <summary>
        /// 关联的漏洞编号数组
        /// </summary>
        [JsonProperty("RelateVulList")]
        public string[] RelateVulList{ get; set; }

        /// <summary>
        /// 是否为最新披露，0否，1是，默认为否
        /// </summary>
        [JsonProperty("IsNew")]
        public long? IsNew{ get; set; }

        /// <summary>
        /// 最后扫描时间
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// 0待处理,1忽略,3修复
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 安装该kb的前置条件，一般为其他kb，且可能有多个，kb之间用", "分隔
        /// </summary>
        [JsonProperty("KbPreCondition")]
        public string KbPreCondition{ get; set; }

        /// <summary>
        /// 该kb关联的windows product名称
        /// </summary>
        [JsonProperty("RelatedProduct")]
        public string RelatedProduct{ get; set; }

        /// <summary>
        /// 补丁id
        /// </summary>
        [JsonProperty("KbId")]
        public ulong? KbId{ get; set; }

        /// <summary>
        /// 相关kb事件的id集合
        /// </summary>
        [JsonProperty("Ids")]
        public string Ids{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "KbNo", this.KbNo);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "EffectHostCount", this.EffectHostCount);
            this.SetParamSimple(map, prefix + "RelateVulCount", this.RelateVulCount);
            this.SetParamArraySimple(map, prefix + "RelateVulList.", this.RelateVulList);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "KbPreCondition", this.KbPreCondition);
            this.SetParamSimple(map, prefix + "RelatedProduct", this.RelatedProduct);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "Ids", this.Ids);
        }
    }
}

