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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEngineRequest : AbstractModel
    {
        
        /// <summary>
        /// 引擎类型。参考值：
        /// - zookeeper
        /// - nacos
        /// - consul
        /// - apollo
        /// - eureka
        /// - polaris
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// 引擎的开源版本。每种引擎支持的开源版本不同，请参考产品文档或者控制台购买页
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// 引擎的产品版本。参考值：
        /// - STANDARD： 标准版
        /// 
        /// 引擎各版本及可选择的规格、节点数说明：
        /// apollo - STANDARD版本
        /// 规格列表：1C2G、2C4G、4C8G、8C16G、16C32G
        /// 节点数：1，2，3，4，5
        /// 
        /// eureka - STANDARD版本
        /// 规格列表：1C2G、2C4G、4C8G、8C16G、16C32G
        /// 节点数：3，4，5
        /// 
        /// polarismesh - STANDARD版本
        /// 规格列表：NUM50、NUM100、NUM200、NUM500、NUM1000、NUM5000、NUM10000、NUM50000
        /// 
        /// 兼容原spec-xxxxxx形式的规格ID
        /// </summary>
        [JsonProperty("EngineProductVersion")]
        public string EngineProductVersion{ get; set; }

        /// <summary>
        /// 引擎所在地域。参考值说明：
        /// 中国区 参考值：
        /// - ap-guangzhou：广州
        /// - ap-beijing：北京
        /// - ap-chengdu：成都
        /// - ap-chongqing：重庆
        /// - ap-nanjing：南京
        /// - ap-shanghai：上海
        /// - ap-hongkong：香港
        /// - ap-taipei：台北
        /// 亚太区 参考值：
        /// - ap-jakarta：雅加达
        /// - ap-singapore：新加坡
        /// 北美区 参考值
        /// - na-toronto：多伦多
        /// 金融专区 参考值
        /// - ap-beijing-fsi：北京金融
        /// - ap-shanghai-fsi：上海金融
        /// - ap-shenzhen-fsi：深圳金融
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// 引擎名称。参考值：
        /// - eurek-test
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// 付费类型。参考值：
        /// - 0：后付费
        /// - 1：预付费（接口暂不支持创建预付费实例）
        /// </summary>
        [JsonProperty("TradeType")]
        public long? TradeType{ get; set; }

        /// <summary>
        /// 引擎的节点规格 ID。参见EngineProductVersion字段说明
        /// </summary>
        [JsonProperty("EngineResourceSpec")]
        public string EngineResourceSpec{ get; set; }

        /// <summary>
        /// 引擎的节点数量。参见EngineProductVersion字段说明
        /// </summary>
        [JsonProperty("EngineNodeNum")]
        public long? EngineNodeNum{ get; set; }

        /// <summary>
        /// VPC ID。在 VPC 的子网内分配一个 IP 作为引擎的访问地址。参考值：
        /// - vpc-conz6aix
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网 ID。在 VPC 的子网内分配一个 IP 作为引擎的访问地址。参考值：
        /// - subnet-ahde9me9
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Apollo 环境配置参数列表。参数说明：
        /// 如果创建Apollo类型，此参数为必填的环境信息列表，最多可选4个环境。环境信息参数说明：
        /// - Name：环境名。参考值：prod, dev, fat, uat
        /// - EngineResourceSpec：环境内引擎的节点规格ID。参见EngineProductVersion参数说明
        /// - EngineNodeNum：环境内引擎的节点数量。参见EngineProductVersion参数说明，其中prod环境支持的节点数为2，3，4，5
        /// - StorageCapacity：配置存储空间大小，以GB为单位，步长为5.参考值：35
        /// - VpcId：VPC ID。参考值：vpc-conz6aix
        /// - SubnetId：子网 ID。参考值：subnet-ahde9me9
        /// </summary>
        [JsonProperty("ApolloEnvParams")]
        public ApolloEnvParam[] ApolloEnvParams{ get; set; }

        /// <summary>
        /// 引擎的标签列表。用户自定义的key/value形式，无参考值
        /// </summary>
        [JsonProperty("EngineTags")]
        public InstanceTagInfo[] EngineTags{ get; set; }

        /// <summary>
        /// 引擎的初始帐号信息。可设置参数：
        /// - Name：控制台初始用户名
        /// - Password：控制台初始密码
        /// - Token：引擎接口的管理员 Token
        /// </summary>
        [JsonProperty("EngineAdmin")]
        public EngineAdmin EngineAdmin{ get; set; }

        /// <summary>
        /// 预付费时长，以月为单位
        /// </summary>
        [JsonProperty("PrepaidPeriod")]
        public long? PrepaidPeriod{ get; set; }

        /// <summary>
        /// 自动续费标记，仅预付费使用。参考值：
        /// - 0：不自动续费
        /// - 1：自动续费
        /// </summary>
        [JsonProperty("PrepaidRenewFlag")]
        public long? PrepaidRenewFlag{ get; set; }

        /// <summary>
        /// 跨地域部署的引擎地域配置详情
        /// </summary>
        [JsonProperty("EngineRegionInfos")]
        public EngineRegionInfo[] EngineRegionInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "EngineProductVersion", this.EngineProductVersion);
            this.SetParamSimple(map, prefix + "EngineRegion", this.EngineRegion);
            this.SetParamSimple(map, prefix + "EngineName", this.EngineName);
            this.SetParamSimple(map, prefix + "TradeType", this.TradeType);
            this.SetParamSimple(map, prefix + "EngineResourceSpec", this.EngineResourceSpec);
            this.SetParamSimple(map, prefix + "EngineNodeNum", this.EngineNodeNum);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "ApolloEnvParams.", this.ApolloEnvParams);
            this.SetParamArrayObj(map, prefix + "EngineTags.", this.EngineTags);
            this.SetParamObj(map, prefix + "EngineAdmin.", this.EngineAdmin);
            this.SetParamSimple(map, prefix + "PrepaidPeriod", this.PrepaidPeriod);
            this.SetParamSimple(map, prefix + "PrepaidRenewFlag", this.PrepaidRenewFlag);
            this.SetParamArrayObj(map, prefix + "EngineRegionInfos.", this.EngineRegionInfos);
        }
    }
}

