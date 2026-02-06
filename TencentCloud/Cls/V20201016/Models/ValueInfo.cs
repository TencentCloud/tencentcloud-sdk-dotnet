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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ValueInfo : AbstractModel
    {
        
        /// <summary>
        /// 字段类型，支持的类型有：long、text、double、json
        /// 注意：json 类型目前仅部分用户或日志主题支持，如需使用请联系我们开启功能白名单
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 字段的分词符，其中的每个字符代表一个分词符；
        /// 仅支持英文符号、\n\t\r及转义符\；
        /// long及double类型字段需为空；
        /// 注意：\n\t\r本身已被转义，直接使用双引号包裹即可作为入参，无需再次转义。使用API Explorer进行调试时请使用JSON参数输入方式，以避免\n\t\r被重复转义
        /// </summary>
        [JsonProperty("Tokenizer")]
        public string Tokenizer{ get; set; }

        /// <summary>
        /// 字段是否开启分析功能
        /// </summary>
        [JsonProperty("SqlFlag")]
        public bool? SqlFlag{ get; set; }

        /// <summary>
        /// 是否包含中文，long及double类型字段需为false
        /// </summary>
        [JsonProperty("ContainZH")]
        public bool? ContainZH{ get; set; }

        /// <summary>
        /// 字段别名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 仅为子节点开启索引，本字段不开启。
        /// 注意：仅json类型字段可配置该参数
        /// </summary>
        [JsonProperty("OpenIndexForChildOnly")]
        public bool? OpenIndexForChildOnly{ get; set; }

        /// <summary>
        /// json子节点列表
        /// 注意：仅json类型字段可配置该参数
        /// </summary>
        [JsonProperty("ChildNode")]
        public KeyValueInfo[] ChildNode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Tokenizer", this.Tokenizer);
            this.SetParamSimple(map, prefix + "SqlFlag", this.SqlFlag);
            this.SetParamSimple(map, prefix + "ContainZH", this.ContainZH);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "OpenIndexForChildOnly", this.OpenIndexForChildOnly);
            this.SetParamArrayObj(map, prefix + "ChildNode.", this.ChildNode);
        }
    }
}

