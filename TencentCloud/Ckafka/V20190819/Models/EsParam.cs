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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EsParam : AbstractModel
    {
        
        /// <summary>
        /// Es实例资源Id
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// Es的连接port
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Es用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Es密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 是否为自建集群
        /// </summary>
        [JsonProperty("SelfBuilt")]
        public bool? SelfBuilt{ get; set; }

        /// <summary>
        /// 实例vip
        /// </summary>
        [JsonProperty("ServiceVip")]
        public string ServiceVip{ get; set; }

        /// <summary>
        /// 实例的vpcId
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Es是否抛弃解析失败的消息
        /// </summary>
        [JsonProperty("DropInvalidMessage")]
        public bool? DropInvalidMessage{ get; set; }

        /// <summary>
        /// Es自定义index名称
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// Es自定义日期后缀
        /// </summary>
        [JsonProperty("DateFormat")]
        public string DateFormat{ get; set; }

        /// <summary>
        /// 非json格式数据的自定义key
        /// </summary>
        [JsonProperty("ContentKey")]
        public string ContentKey{ get; set; }

        /// <summary>
        /// Es是否抛弃非json格式的消息
        /// </summary>
        [JsonProperty("DropInvalidJsonMessage")]
        public bool? DropInvalidJsonMessage{ get; set; }

        /// <summary>
        /// 转储到Es中的文档ID取值字段名
        /// </summary>
        [JsonProperty("DocumentIdField")]
        public string DocumentIdField{ get; set; }

        /// <summary>
        /// Es自定义index名称的类型，STRING，JSONPATH，默认为STRING
        /// </summary>
        [JsonProperty("IndexType")]
        public string IndexType{ get; set; }

        /// <summary>
        /// 当设置成员参数DropInvalidMessageToCls设置为true时,DropInvalidMessage参数失效
        /// </summary>
        [JsonProperty("DropCls")]
        public DropCls DropCls{ get; set; }

        /// <summary>
        /// 转储到ES的消息为Database的binlog时，如果需要同步数据库操作，即增删改的操作到ES时填写数据库表主键
        /// </summary>
        [JsonProperty("DatabasePrimaryKey")]
        public string DatabasePrimaryKey{ get; set; }

        /// <summary>
        /// 死信队列
        /// </summary>
        [JsonProperty("DropDlq")]
        public FailureParam DropDlq{ get; set; }

        /// <summary>
        /// 使用数据订阅格式导入 es 时，消息与 es 索引字段映射关系。不填默认为默认字段匹配
        /// </summary>
        [JsonProperty("RecordMappingList")]
        public EsRecordMapping[] RecordMappingList{ get; set; }

        /// <summary>
        /// 消息要映射为 es 索引中 @timestamp 的字段，如果当前配置为空，则使用消息的时间戳进行映射
        /// </summary>
        [JsonProperty("DateField")]
        public string DateField{ get; set; }

        /// <summary>
        /// 用来区分当前索引映射，属于新建索引还是存量索引。"EXIST_MAPPING"：从存量索引中选择；"NEW_MAPPING"：新建索引
        /// </summary>
        [JsonProperty("RecordMappingMode")]
        public string RecordMappingMode{ get; set; }


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
        }
    }
}

