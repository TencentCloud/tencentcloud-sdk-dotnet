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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspaDiscoveryLevelDetail : AbstractModel
    {
        
        /// <summary>
        /// 分级组名称，唯一性约束，最多60个字符，仅允许输入中文、英文字母、数字、'_'、'-'，并且开头和结尾需为中文、英文字母或者数字，Name不可重复
        /// </summary>
        [JsonProperty("LevelGroupName")]
        public string LevelGroupName{ get; set; }

        /// <summary>
        /// 分级组来源，0为内置，1为自定义
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 分级组描述，最多1024字符
        /// </summary>
        [JsonProperty("LevelGroupDesc")]
        public string LevelGroupDesc{ get; set; }

        /// <summary>
        /// 具体分级标识详情
        /// </summary>
        [JsonProperty("LevelDetail")]
        public LevelItem[] LevelDetail{ get; set; }

        /// <summary>
        /// 引用合规组次数
        /// </summary>
        [JsonProperty("RefComplianceCnt")]
        public ulong? RefComplianceCnt{ get; set; }

        /// <summary>
        /// 引用合规组
        /// </summary>
        [JsonProperty("RefCompliance")]
        public DspaDiscoveryComplianceGroup[] RefCompliance{ get; set; }

        /// <summary>
        /// 分级组ID
        /// </summary>
        [JsonProperty("LevelGroupId")]
        public ulong? LevelGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LevelGroupName", this.LevelGroupName);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "LevelGroupDesc", this.LevelGroupDesc);
            this.SetParamArrayObj(map, prefix + "LevelDetail.", this.LevelDetail);
            this.SetParamSimple(map, prefix + "RefComplianceCnt", this.RefComplianceCnt);
            this.SetParamArrayObj(map, prefix + "RefCompliance.", this.RefCompliance);
            this.SetParamSimple(map, prefix + "LevelGroupId", this.LevelGroupId);
        }
    }
}

