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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiDatasourceConfig : AbstractModel
    {
        
        /// <summary>
        /// API数据源解析结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldsJsonData")]
        public string FieldsJsonData{ get; set; }

        /// <summary>
        /// 连接类型1:直连 2:抽取
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectionType")]
        public ulong? ConnectionType{ get; set; }

        /// <summary>
        /// 抽取频率配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrequencyConfig")]
        public FrequencyConfig FrequencyConfig{ get; set; }

        /// <summary>
        /// 请求URL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 1:GET 2:POST
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestMethod")]
        public ulong? RequestMethod{ get; set; }

        /// <summary>
        /// 请求头
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestHeader")]
        public string RequestHeader{ get; set; }

        /// <summary>
        /// 请求参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestParams")]
        public string RequestParams{ get; set; }

        /// <summary>
        /// 请求体
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestBody")]
        public string RequestBody{ get; set; }

        /// <summary>
        /// 用户名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 密码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 1: 无鉴权 2:BASIC_AUTH
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthorizationType")]
        public ulong? AuthorizationType{ get; set; }

        /// <summary>
        /// 表id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableId")]
        public ulong? TableId{ get; set; }

        /// <summary>
        /// 路径DbName映射
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JsonPathDbNameMap")]
        public string JsonPathDbNameMap{ get; set; }

        /// <summary>
        /// 鉴权API
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthApi")]
        public string AuthApi{ get; set; }

        /// <summary>
        /// 应用Key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// 应用密钥
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppSecret")]
        public string AppSecret{ get; set; }

        /// <summary>
        /// 数据密钥Key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// 数据密钥初始化向量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretIv")]
        public string SecretIv{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FieldsJsonData", this.FieldsJsonData);
            this.SetParamSimple(map, prefix + "ConnectionType", this.ConnectionType);
            this.SetParamObj(map, prefix + "FrequencyConfig.", this.FrequencyConfig);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "RequestMethod", this.RequestMethod);
            this.SetParamSimple(map, prefix + "RequestHeader", this.RequestHeader);
            this.SetParamSimple(map, prefix + "RequestParams", this.RequestParams);
            this.SetParamSimple(map, prefix + "RequestBody", this.RequestBody);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "AuthorizationType", this.AuthorizationType);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "JsonPathDbNameMap", this.JsonPathDbNameMap);
            this.SetParamSimple(map, prefix + "AuthApi", this.AuthApi);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "AppSecret", this.AppSecret);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "SecretIv", this.SecretIv);
        }
    }
}

