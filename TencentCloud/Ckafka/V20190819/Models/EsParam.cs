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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EsParam : AbstractModel
    {
        
        /// <summary>
        /// <p>Es实例资源Id</p>
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// <p>Es的连接port</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>Es用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>Es密码</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>是否为自建集群</p>
        /// </summary>
        [JsonProperty("SelfBuilt")]
        public bool? SelfBuilt{ get; set; }

        /// <summary>
        /// <p>实例vip</p>
        /// </summary>
        [JsonProperty("ServiceVip")]
        public string ServiceVip{ get; set; }

        /// <summary>
        /// <p>实例的vpcId</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>Es是否抛弃解析失败的消息</p>
        /// </summary>
        [JsonProperty("DropInvalidMessage")]
        public bool? DropInvalidMessage{ get; set; }

        /// <summary>
        /// <p>Es自定义index名称</p>
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// <p>Es自定义日期后缀</p>
        /// </summary>
        [JsonProperty("DateFormat")]
        public string DateFormat{ get; set; }

        /// <summary>
        /// <p>非json格式数据的自定义key</p>
        /// </summary>
        [JsonProperty("ContentKey")]
        public string ContentKey{ get; set; }

        /// <summary>
        /// <p>Es是否抛弃非json格式的消息</p>
        /// </summary>
        [JsonProperty("DropInvalidJsonMessage")]
        public bool? DropInvalidJsonMessage{ get; set; }

        /// <summary>
        /// <p>转储到Es中的文档ID取值字段名</p>
        /// </summary>
        [JsonProperty("DocumentIdField")]
        public string DocumentIdField{ get; set; }

        /// <summary>
        /// <p>Es自定义index名称的类型，STRING，JSONPATH，默认为STRING</p>
        /// </summary>
        [JsonProperty("IndexType")]
        public string IndexType{ get; set; }

        /// <summary>
        /// <p>当设置成员参数DropInvalidMessageToCls设置为true时,DropInvalidMessage参数失效</p>
        /// </summary>
        [JsonProperty("DropCls")]
        public DropCls DropCls{ get; set; }

        /// <summary>
        /// <p>转储到ES的消息为Database的binlog时，如果需要同步数据库操作，即增删改的操作到ES时填写数据库表主键</p>
        /// </summary>
        [JsonProperty("DatabasePrimaryKey")]
        public string DatabasePrimaryKey{ get; set; }

        /// <summary>
        /// <p>死信队列</p>
        /// </summary>
        [JsonProperty("DropDlq")]
        public FailureParam DropDlq{ get; set; }

        /// <summary>
        /// <p>使用数据订阅格式导入 es 时，消息与 es 索引字段映射关系。不填默认为默认字段匹配</p>
        /// </summary>
        [JsonProperty("RecordMappingList")]
        public EsRecordMapping[] RecordMappingList{ get; set; }

        /// <summary>
        /// <p>消息要映射为 es 索引中 @timestamp 的字段，如果当前配置为空，则使用消息的时间戳进行映射</p>
        /// </summary>
        [JsonProperty("DateField")]
        public string DateField{ get; set; }

        /// <summary>
        /// <p>用来区分当前索引映射，属于新建索引还是存量索引。&quot;EXIST_MAPPING&quot;：从存量索引中选择；&quot;NEW_MAPPING&quot;：新建索引</p>
        /// </summary>
        [JsonProperty("RecordMappingMode")]
        public string RecordMappingMode{ get; set; }

        /// <summary>
        /// <p>集群版 ES 连接协议，默认http协议</p><p>枚举值：</p><ul><li>http： http协议</li><li>https： https协议</li></ul>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "SelfBuilt", this.SelfBuilt);
            this.SetParamSimple(map, prefix + "ServiceVip", this.ServiceVip);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "DropInvalidMessage", this.DropInvalidMessage);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "DateFormat", this.DateFormat);
            this.SetParamSimple(map, prefix + "ContentKey", this.ContentKey);
            this.SetParamSimple(map, prefix + "DropInvalidJsonMessage", this.DropInvalidJsonMessage);
            this.SetParamSimple(map, prefix + "DocumentIdField", this.DocumentIdField);
            this.SetParamSimple(map, prefix + "IndexType", this.IndexType);
            this.SetParamObj(map, prefix + "DropCls.", this.DropCls);
            this.SetParamSimple(map, prefix + "DatabasePrimaryKey", this.DatabasePrimaryKey);
            this.SetParamObj(map, prefix + "DropDlq.", this.DropDlq);
            this.SetParamArrayObj(map, prefix + "RecordMappingList.", this.RecordMappingList);
            this.SetParamSimple(map, prefix + "DateField", this.DateField);
            this.SetParamSimple(map, prefix + "RecordMappingMode", this.RecordMappingMode);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
        }
    }
}

