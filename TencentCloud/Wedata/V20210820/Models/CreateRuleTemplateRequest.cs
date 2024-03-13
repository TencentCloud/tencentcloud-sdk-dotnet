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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRuleTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板类型  1.系统模板   2.自定义模板
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 质量检测维度 1.准确性 2.唯一性 3.完整性 4.一致性 5.及时性 6.有效性
        /// </summary>
        [JsonProperty("QualityDim")]
        public ulong? QualityDim{ get; set; }

        /// <summary>
        /// 源端数据对象类型 1.常量  2.离线表级   2.离线字段级
        /// </summary>
        [JsonProperty("SourceObjectType")]
        public ulong? SourceObjectType{ get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 源端对应的引擎类型
        /// </summary>
        [JsonProperty("SourceEngineTypes")]
        public ulong?[] SourceEngineTypes{ get; set; }

        /// <summary>
        /// 是否关联其它库表
        /// </summary>
        [JsonProperty("MultiSourceFlag")]
        public bool? MultiSourceFlag{ get; set; }

        /// <summary>
        /// SQL 表达式
        /// </summary>
        [JsonProperty("SqlExpression")]
        public string SqlExpression{ get; set; }

        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 是否添加where参数
        /// </summary>
        [JsonProperty("WhereFlag")]
        public bool? WhereFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "QualityDim", this.QualityDim);
            this.SetParamSimple(map, prefix + "SourceObjectType", this.SourceObjectType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "SourceEngineTypes.", this.SourceEngineTypes);
            this.SetParamSimple(map, prefix + "MultiSourceFlag", this.MultiSourceFlag);
            this.SetParamSimple(map, prefix + "SqlExpression", this.SqlExpression);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WhereFlag", this.WhereFlag);
        }
    }
}

