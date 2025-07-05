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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigSetInfo : AbstractModel
    {
        
        /// <summary>
        /// 配置集名称
        /// </summary>
        [JsonProperty("ConfigSet")]
        public string ConfigSet{ get; set; }

        /// <summary>
        /// 容量调度器会使用，里面设置了标签相关的配置。key的取值与**DescribeYarnQueue**返回的字段一致。
        /// key的取值信息如下：
        /// - labelName，标签名称，标签管理里的标签。
        /// - capacity，容量，取值为**数字字符串**
        /// - maximum-capacity，最大容量，取值为**数字字符串**
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelParams")]
        public ItemSeq[] LabelParams{ get; set; }

        /// <summary>
        /// 设置配置集相关的参数。key的取值与**DescribeYarnQueue**返回的字段一致。
        /// ###### 公平调度器
        /// key的取值信息如下：
        /// - minResources，最大资源量，取值为**YarnResource类型的json串**或**null**
        /// - maxResources，最大资源量，取值为**YarnResource类型的json串**或**null**
        /// - maxChildResources，能够分配给为未声明子队列的最大资源量，取值为**数字字符串**或**null**
        /// - maxRunningApps，最高可同时处于运行的App数量，取值为**数字字符串**或**null**
        /// - weight，权重，取值为**数字字符串**或**null**
        /// - maxAMShare，App Master最大份额，取值为**数字字符串**或**null**，其中数字的范围是[0，1]或-1
        /// 
        /// ```
        /// type YarnResource struct {
        /// 	Vcores *int `json:"vcores"`
        /// 	Memory *int `json:"memory"`
        /// 	Type *string `json:"type"` // 取值为`percent`或`null`当值为`percent`时，表示使用的百分比，否则就是使用的绝对数值。只有maxResources、maxChildResources才可以取值为`percent`
        /// }
        /// ```
        /// 
        /// ###### 容量调度器
        /// key的取值信息如下：
        /// - minimum-user-limit-percent，用户最小容量，取值为**YarnResource类型的json串**或**null**，其中数字的范围是[0，100]
        /// - user-limit-factor，用户资源因子，取值为**YarnResource类型的json串**或**null**
        /// - maximum-applications，最大应用数Max-Applications，取值为**数字字符串**或**null**，其中数字为正整数
        /// - maximum-am-resource-percent，最大AM比例，取值为**数字字符串**或**null**，其中数字的范围是[0，1]或-1
        /// - default-application-priority，资源池优先级，取值为**数字字符串**或**null**，其中数字为正整数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicParams")]
        public Item[] BasicParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigSet", this.ConfigSet);
            this.SetParamArrayObj(map, prefix + "LabelParams.", this.LabelParams);
            this.SetParamArrayObj(map, prefix + "BasicParams.", this.BasicParams);
        }
    }
}

