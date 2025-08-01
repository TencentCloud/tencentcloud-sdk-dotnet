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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataEngineImageSessionParameter : AbstractModel
    {
        
        /// <summary>
        /// 配置id
        /// </summary>
        [JsonProperty("ParameterId")]
        public string ParameterId{ get; set; }

        /// <summary>
        /// 小版本镜像ID
        /// </summary>
        [JsonProperty("ChildImageVersionId")]
        public string ChildImageVersionId{ get; set; }

        /// <summary>
        /// 集群类型：SparkSQL/PrestoSQL/SparkBatch
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// 参数key
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// Key描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyDescription")]
        public string KeyDescription{ get; set; }

        /// <summary>
        /// value类型
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// value长度限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueLengthLimit")]
        public string ValueLengthLimit{ get; set; }

        /// <summary>
        /// value正则限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueRegexpLimit")]
        public string ValueRegexpLimit{ get; set; }

        /// <summary>
        /// value默认值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueDefault")]
        public string ValueDefault{ get; set; }

        /// <summary>
        /// 是否为公共版本：1：公共；2：私有
        /// </summary>
        [JsonProperty("IsPublic")]
        public ulong? IsPublic{ get; set; }

        /// <summary>
        /// 配置类型：1：session配置（默认）；2：common配置；3：cluster配置
        /// </summary>
        [JsonProperty("ParameterType")]
        public ulong? ParameterType{ get; set; }

        /// <summary>
        /// 提交方式：User(用户)、BackGround（后台）
        /// </summary>
        [JsonProperty("SubmitMethod")]
        public string SubmitMethod{ get; set; }

        /// <summary>
        /// 操作者
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 插入时间
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParameterId", this.ParameterId);
            this.SetParamSimple(map, prefix + "ChildImageVersionId", this.ChildImageVersionId);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "KeyDescription", this.KeyDescription);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "ValueLengthLimit", this.ValueLengthLimit);
            this.SetParamSimple(map, prefix + "ValueRegexpLimit", this.ValueRegexpLimit);
            this.SetParamSimple(map, prefix + "ValueDefault", this.ValueDefault);
            this.SetParamSimple(map, prefix + "IsPublic", this.IsPublic);
            this.SetParamSimple(map, prefix + "ParameterType", this.ParameterType);
            this.SetParamSimple(map, prefix + "SubmitMethod", this.SubmitMethod);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

