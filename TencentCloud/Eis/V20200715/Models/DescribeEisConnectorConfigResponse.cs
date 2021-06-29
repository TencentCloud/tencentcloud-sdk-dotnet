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

namespace TencentCloud.Eis.V20200715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEisConnectorConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 连接器配置参数描述（json结构），示例如下：
        /// {
        ///     "attributes":{
        ///         "description":"测试", // 连接器的描述
        ///         "displayName":"测试", // 连接器的展示名
        ///         "name":"test", // 连接器的名称
        ///         "version":"1.0.0" // 连接器的版本号
        ///     },
        ///     "properties":[
        ///         {
        ///             "attributes":{
        ///                 "displayName":"企业ID", // 参数的展示名
        ///                 "name":"para1", // 参数名
        ///                 "required":"true", // 是否必填
        ///                 "type":"int" // 参数的类型
        ///             }
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"成员管理密钥",
        ///                 "name":"para2",
        ///                 "required":"true",
        ///                 "type":"float"
        ///             }
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"应用管理密钥",
        ///                 "name":"para3",
        ///                 "required":"true",
        ///                 "type":"string"
        ///             }
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"企业ID",
        ///                 "name":"para4",
        ///                 "required":"true",
        ///                 "type":"decimal"
        ///             }
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"成员管理密钥",
        ///                 "name":"para5",
        ///                 "required":"true",
        ///                 "type":"bool"
        ///             }
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"应用管理密钥",
        ///                 "name":"para6",
        ///                 "required":"true",
        ///                 "type":"date"
        ///             }
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"企业ID",
        ///                 "name":"para7",
        ///                 "required":"true",
        ///                 "type":"time"
        ///             }
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"成员管理密钥",
        ///                 "name":"para8",
        ///                 "required":"true",
        ///                 "type":"datetime"
        ///             }
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"应用管理密钥",
        ///                 "name":"para9",
        ///                 "required":"true",
        ///                 "type":"map"
        ///             },
        ///             "children":[
        ///                 {
        ///                     "attributes":{
        ///                         "displayName":"key",
        ///                         "name":"key",
        ///                         "required":"true",
        ///                         "type":"string"
        ///                     }
        ///                 },
        ///                 {
        ///                     "attributes":{
        ///                         "displayName":"value",
        ///                         "name":"value",
        ///                         "required":"true",
        ///                         "type":"any"
        ///                     }
        ///                 }
        ///             ]
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"企业ID",
        ///                 "name":"para10",
        ///                 "required":"true",
        ///                 "type":"list" // list，list里元素的类型是结构体，children里是结构体的描述
        ///             },
        ///             "children":[
        ///                 {
        ///                     "attributes":{
        ///                         "displayName":"field1",
        ///                         "name":"field1",
        ///                         "required":"true",
        ///                         "type":"string"
        ///                     }
        ///                 },
        ///                 {
        ///                     "attributes":{
        ///                         "displayName":"field2",
        ///                         "name":"field2",
        ///                         "required":"true",
        ///                         "type":"any"
        ///                     }
        ///                 }
        ///             ]
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"成员管理密钥",
        ///                 "name":"para11",
        ///                 "required":"true",
        ///                 "type":"struct"
        ///             },
        ///             "children":[
        ///                 {
        ///                     "attributes":{
        ///                         "displayName":"field1", // 结构体属性的展示名
        ///                         "name":"field1", // 结构体属性的名称
        ///                         "required":"true", // 是否必填
        ///                         "type":"string" // 属性的类型
        ///                     }
        ///                 },
        ///                 {
        ///                     "attributes":{
        ///                         "displayName":"field2",
        ///                         "name":"field2",
        ///                         "required":"true",
        ///                         "type":"any"
        ///                     }
        ///                 }
        ///             ]
        ///         },
        ///         {
        ///             "attributes":{
        ///                 "displayName":"应用管理密钥",
        ///                 "name":"para12",
        ///                 "required":"true",
        ///                 "type":"enum"
        ///             },
        ///             "children":[
        ///                 {
        ///                     "attributes":{
        ///                         "displayName":"PC", // 枚举值的展示名
        ///                         "name":"PC" // 枚举值的名称
        ///                     }
        ///                 },
        ///                 {
        ///                     "attributes":{
        ///                         "displayName":"MAC",
        ///                         "name":"MAC"
        ///                     }
        ///                 }
        ///             ]
        ///         }
        ///     ]
        /// }
        /// </summary>
        [JsonProperty("ConnectorParameter")]
        public string ConnectorParameter{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConnectorParameter", this.ConnectorParameter);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

