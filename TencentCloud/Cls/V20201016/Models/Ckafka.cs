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

    public class Ckafka : AbstractModel
    {
        
        /// <summary>
        /// Ckafka 的 InstanceId。
        /// - 通过 [获取实例列表信息](https://cloud.tencent.com/document/product/597/40835) 获取实例id。
        /// - 通过 [创建实例](https://cloud.tencent.com/document/product/597/53207) 获取实例id。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Ckafka 的 TopicName。
        /// - 通过 [创建 Topic](https://cloud.tencent.com/document/product/597/73566) 获得TopicName。
        /// - 通过 [获取主题列表](https://cloud.tencent.com/document/product/597/40847) 获得TopicName。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Ckafka 的 Vip。
        /// - 通过 [获取实例属性 ](https://cloud.tencent.com/document/product/597/40836) 获取vip信息。
        /// - 如果是通过 角色ARN 方式创建投递任务，则Vip字段可为空。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Ckafka 的 Vport。
        /// - 通过 [获取实例属性 ](https://cloud.tencent.com/document/product/597/40836) 获取vip port信息。
        /// - 如果是通过 角色ARN 方式创建投递任务，则Vport字段可为空。
        /// </summary>
        [JsonProperty("Vport")]
        public string Vport{ get; set; }

        /// <summary>
        /// Ckafka 的 InstanceName。
        /// - 通过 [获取实例列表信息](https://cloud.tencent.com/document/product/597/40835) 获取InstanceName。
        /// - 通过 [创建实例](https://cloud.tencent.com/document/product/597/53207) 获取InstanceName。
        /// - 如果是通过 角色ARN 方式创建投递任务，则InstanceName字段可为空。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Ckafka 的 TopicId。
        /// - 通过 [创建 Topic](https://cloud.tencent.com/document/product/597/73566) 获得TopicId。
        /// - 通过 [获取主题列表](https://cloud.tencent.com/document/product/597/40847) 获得TopicId。
        /// - 如果是通过 角色ARN 方式创建投递任务，则TopicId字段可为空。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
        }
    }
}

