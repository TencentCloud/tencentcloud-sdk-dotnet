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

    public class FileTamperRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 规则类型 0 ：系统规则  1：用户规则
        /// </summary>
        [JsonProperty("RuleCategory")]
        public ulong? RuleCategory{ get; set; }

        /// <summary>
        /// 影响主机数
        /// </summary>
        [JsonProperty("HostCount")]
        public ulong? HostCount{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 状态 0: 启用 1: 已关闭
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 规则id，系统的规则时为0。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 是否是全局的 0：否 ，1：是
        /// </summary>
        [JsonProperty("IsGlobal")]
        public ulong? IsGlobal{ get; set; }

        /// <summary>
        /// 风险等级 0：无， 1: 高危， 2:中危， 3: 低危
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 子规则写条目数
        /// </summary>
        [JsonProperty("WriteRuleCount")]
        public ulong? WriteRuleCount{ get; set; }

        /// <summary>
        /// 子规则读条目数
        /// </summary>
        [JsonProperty("ReadRuleCount")]
        public ulong? ReadRuleCount{ get; set; }

        /// <summary>
        /// 子规则读写条目数
        /// </summary>
        [JsonProperty("ReadWriteRuleCount")]
        public ulong? ReadWriteRuleCount{ get; set; }

        /// <summary>
        /// 监控行为
        /// <li>read 读取文件</li>
        /// <li>write 修改文件</li>
        /// <li>read-write 读取修改文件</li>
        /// </summary>
        [JsonProperty("FileAction")]
        public string FileAction{ get; set; }

        /// <summary>
        /// 加白处理类型
        /// <li>cur 仅对当前加白</li>
        /// <li>all 所有符合条件加白</li>
        /// </summary>
        [JsonProperty("AddWhiteType")]
        public string AddWhiteType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RuleCategory", this.RuleCategory);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "WriteRuleCount", this.WriteRuleCount);
            this.SetParamSimple(map, prefix + "ReadRuleCount", this.ReadRuleCount);
            this.SetParamSimple(map, prefix + "ReadWriteRuleCount", this.ReadWriteRuleCount);
            this.SetParamSimple(map, prefix + "FileAction", this.FileAction);
            this.SetParamSimple(map, prefix + "AddWhiteType", this.AddWhiteType);
        }
    }
}

