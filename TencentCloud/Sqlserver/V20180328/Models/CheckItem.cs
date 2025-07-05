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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckItem : AbstractModel
    {
        
        /// <summary>
        /// 检查项目名称，CK_CPU-变配后CPU风险检查；CK_MASTER_STORAGE-只读副本变配下，只读副本磁盘空间不小于主实例空间检查；CK_MEMORY-变配后内存风险检查；CK_STORAGE-变配后磁盘空间风险检查；CK_UPGRATE-变配是否需要迁移检查；
        /// </summary>
        [JsonProperty("CheckName")]
        public string CheckName{ get; set; }

        /// <summary>
        /// 检查项目返回值，CK_CPU-当前CPU近7天最大的使用率(%) ；CK_MASTER_STORAGE-主实例的磁盘空间(GB)；CK_MEMORY-当前内存近7天最大的使用值（GB)；
        /// CK_STORAGE-当前磁盘近7天最大的使用值（GB)；CK_UPGRATE- 当前变配检查是否需要迁移，MIGRATE需要迁移变配，LOCAL本地变配；
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// 检查条目是否通过 0-不通过，不能变配； 1-通过，可以变配
        /// </summary>
        [JsonProperty("Passed")]
        public long? Passed{ get; set; }

        /// <summary>
        /// 本条目变配是否对实例有影响 0-没有影响 1-有影响
        /// </summary>
        [JsonProperty("IsAffect")]
        public long? IsAffect{ get; set; }

        /// <summary>
        /// 有影响或者不通过的情况下的必要描述
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// 描述对应的代码
        /// </summary>
        [JsonProperty("MsgCode")]
        public long? MsgCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckName", this.CheckName);
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Passed", this.Passed);
            this.SetParamSimple(map, prefix + "IsAffect", this.IsAffect);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "MsgCode", this.MsgCode);
        }
    }
}

