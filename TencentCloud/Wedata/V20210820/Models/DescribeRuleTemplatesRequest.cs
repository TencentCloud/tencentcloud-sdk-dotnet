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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRuleTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 模版类型：1-系统模版，2-用户自定义模版
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 源数据对象类型：1-常量，2-离线表级，3-离线字段级别
        /// </summary>
        [JsonProperty("SourceObjectType")]
        public ulong? SourceObjectType{ get; set; }

        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 执行引擎多选（位运算数组）：2-HIVE，4-SPARK，8-LIVY，16-DLC，64-TCHouse-P，128-DORIS，256-TCHouse-D，512-EMR-StarRocks，1024-TCHouse-X
        /// </summary>
        [JsonProperty("SourceEngineTypes")]
        public ulong?[] SourceEngineTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SourceObjectType", this.SourceObjectType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "SourceEngineTypes.", this.SourceEngineTypes);
        }
    }
}

