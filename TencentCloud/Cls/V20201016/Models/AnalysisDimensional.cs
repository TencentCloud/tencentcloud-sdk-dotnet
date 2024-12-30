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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalysisDimensional : AbstractModel
    {
        
        /// <summary>
        /// 分析名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分析类型：query，field ，original
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 分析内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 多维分析配置。
        /// 
        /// 当Analysis的Type字段为query（自定义）时，支持
        /// {
        /// "Key": "SyntaxRule",  // 语法规则
        /// "Value": "1"  //0：Lucene语法 ，1： CQL语法
        /// }
        /// 
        /// 当Analysis的Type字段为field（top5）时,  支持
        ///  {
        ///     "Key": "QueryIndex",
        ///     "Value": "-1" //  -1：自定义， 1：执行语句1， 2：执行语句2
        /// },{
        ///     "Key": "CustomQuery", //检索语句。 QueryIndex为-1时有效且必填
        ///     "Value": "* | select count(*) as count"
        /// },{
        ///     "Key": "SyntaxRule", // 查不到这个字段也是老语法（Lucene）
        ///     "Value": "0"//0:Lucene, 1:CQL
        /// }       
        /// 
        /// 当Analysis的Type字段为original（原始日志）时,  支持
        /// {
        ///     "Key": "Fields",
        ///     "Value": "__SOURCE__,__HOSTNAME__,__TIMESTAMP__,__PKG_LOGID__,__TAG__.pod_ip"
        /// }, {
        ///     "Key": "QueryIndex",
        ///     "Value": "-1" //  -1：自定义， 1：执行语句1， 2：执行语句2
        /// },{
        ///     "Key": "CustomQuery", //  //检索语句。 QueryIndex为-1时有效且必填
        ///     "Value": "* | select count(*) as count"
        /// },{
        ///     "Key": "Format", //显示形式。1：每条日志一行，2：每条日志每个字段一行
        ///     "Value": "2"
        /// },
        /// {
        ///     "Key": "Limit", //最大日志条数
        ///     "Value": "5"
        /// },{
        ///     "Key": "SyntaxRule", // 查不到这个字段也是老语法
        ///     "Value": "0"//0:Lucene, 1:CQL
        /// }
        /// </summary>
        [JsonProperty("ConfigInfo")]
        public AlarmAnalysisConfig[] ConfigInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArrayObj(map, prefix + "ConfigInfo.", this.ConfigInfo);
        }
    }
}

