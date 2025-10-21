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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigureSubscribeJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据订阅实例的 ID，可通过[DescribeSyncJobs](https://cloud.tencent.com/document/product/571/82103)接口获取。
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// 数据订阅的类型，当 DatabaseType 不为 mongodb 时，枚举值为：all-全实例更新；dml-数据更新；ddl-结构更新；dmlAndDdl-数据更新+结构更新。当 DatabaseType 为 mongodb 时，枚举值为 all-全实例更新；database-订阅单库；collection-订阅单集合
        /// </summary>
        [JsonProperty("SubscribeMode")]
        public string SubscribeMode{ get; set; }

        /// <summary>
        /// 源数据库接入类型，如：extranet(公网)、vpncloud(vpn接入)、dcg(专线接入)、ccn(云联网)、cdb(云数据库)、cvm(云服务器自建)、intranet(自研上云)、vpc(私有网络vpc)。注意具体可选值依赖当前链路支持能力
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// 数据库节点信息
        /// </summary>
        [JsonProperty("Endpoints")]
        public EndpointItem[] Endpoints{ get; set; }

        /// <summary>
        /// Kafka配置
        /// </summary>
        [JsonProperty("KafkaConfig")]
        public SubscribeKafkaConfig KafkaConfig{ get; set; }

        /// <summary>
        /// 订阅的数据库表信息，当 SubscribeMode 不为 all和ddl 时，SubscribeObjects 为必选参数
        /// </summary>
        [JsonProperty("SubscribeObjects")]
        public SubscribeObject[] SubscribeObjects{ get; set; }

        /// <summary>
        /// 订阅数据格式，如：protobuf、json、avro。注意具体可选值依赖当前链路支持能力，数据格式详情参考官网的消费demo文档
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// mongo选填参数：输出聚合设置。
        /// </summary>
        [JsonProperty("PipelineInfo")]
        public PipelineInfo[] PipelineInfo{ get; set; }

        /// <summary>
        /// 为业务添加的额外信息。参数名作key，参数值作value。
        /// mysql选填参数：ProcessXA-是否处理XA事务，填true处理，不填或填其他值不处理。
        /// mongo选填参数：SubscribeType-订阅类型，目前只支持changeStream，不填也是默认changeStream。
        /// 其他业务暂没有可选参数。
        /// </summary>
        [JsonProperty("ExtraAttr")]
        public KeyValuePairOption[] ExtraAttr{ get; set; }

        /// <summary>
        /// vpc id
        /// </summary>
        [JsonProperty("ConsumerVpcId")]
        public string ConsumerVpcId{ get; set; }

        /// <summary>
        /// subnet id
        /// </summary>
        [JsonProperty("ConsumerSubnetId")]
        public string ConsumerSubnetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "SubscribeMode", this.SubscribeMode);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArrayObj(map, prefix + "Endpoints.", this.Endpoints);
            this.SetParamObj(map, prefix + "KafkaConfig.", this.KafkaConfig);
            this.SetParamArrayObj(map, prefix + "SubscribeObjects.", this.SubscribeObjects);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "PipelineInfo.", this.PipelineInfo);
            this.SetParamArrayObj(map, prefix + "ExtraAttr.", this.ExtraAttr);
            this.SetParamSimple(map, prefix + "ConsumerVpcId", this.ConsumerVpcId);
            this.SetParamSimple(map, prefix + "ConsumerSubnetId", this.ConsumerSubnetId);
        }
    }
}

