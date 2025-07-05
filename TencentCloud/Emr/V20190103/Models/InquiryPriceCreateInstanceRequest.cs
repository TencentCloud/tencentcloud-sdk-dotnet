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

    public class InquiryPriceCreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 购买实例的时间单位。取值范围：
        /// <li>s：表示秒。PayMode取值为0时，TimeUnit只能取值为s。</li>
        /// <li>m：表示月份。PayMode取值为1时，TimeUnit只能取值为m。</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 购买实例的时长。结合TimeUnit一起使用。
        /// <li>TimeUnit为s时，该参数只能填写3600，表示按量计费实例。</li>
        /// <li>TimeUnit为m时，该参数填写的数字表示包年包月实例的购买时长，如1表示购买一个月</li>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 货币种类。取值范围：
        /// <li>CNY：表示人民币。</li>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 实例计费模式。取值范围：
        /// <li>0：表示按量计费。</li>
        /// <li>1：表示包年包月。</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 是否开启节点高可用。取值范围：
        /// <li>0：表示不开启节点高可用。</li>
        /// <li>1：表示开启节点高可用。</li>
        /// </summary>
        [JsonProperty("SupportHA")]
        public ulong? SupportHA{ get; set; }

        /// <summary>
        /// 部署的组件列表。不同的EMR产品ID（ProductId：具体含义参考入参ProductId字段）需要选择不同的必选组件：<li>ProductId为2(EMR-V2.0.1)的时候，必选组件包括：hdfs-2.7.3,yarn-2.7.3,zookeeper-3.4.9,knox-1.2.0</li><li>ProductId为16(EMR-V2.3.0)的时候，必选组件包括：hdfs-2.8.5,yarn-2.8.5,zookeeper-3.5.5,knox-1.2.0</li><li>ProductId为20(EMR-V2.5.0)的时候，必选组件包括：hdfs-2.8.5,yarn-2.8.5,zookeeper-3.6.1,knox-1.2.0</li><li>ProductId为30(EMR-V2.6.0)的时候，必选组件包括：hdfs-2.8.5,yarn-2.8.5,zookeeper-3.6.1,openldap-2.4.44,knox-1.2.0</li><li>ProductId为38(EMR-V2.7.0)的时候，必选组件包括：hdfs-2.8.5,yarn-2.8.5,zookeeper-3.6.3,openldap-2.4.44,knox-1.6.1</li><li>ProductId为57(EMR-V2.8.0)的时候，必选组件包括：hdfs-2.8.5,yarn-2.8.5,zookeeper-3.6.3,openldap-2.4.44,knox-1.6.1</li><li>ProductId为7(EMR-V3.0.0)的时候，必选组件包括：hdfs-3.1.2,yarn-3.1.2,zookeeper-3.4.9,knox-1.2.0</li><li>ProductId为25(EMR-V3.1.0)的时候，必选组件包括：hdfs-3.1.2,yarn-3.1.2,zookeeper-3.6.1,knox-1.2.0</li><li>ProductId为31(EMR-V3.1.1)的时候，必选组件包括：hdfs-3.1.2,yarn-3.1.2,zookeeper-3.6.1,knox-1.2.0</li><li>ProductId为28(EMR-V3.2.0)的时候，必选组件包括：hdfs-3.2.2,yarn-3.2.2,zookeeper-3.6.1,knox-1.2.0</li><li>ProductId为33(EMR-V3.2.1)的时候，必选组件包括：hdfs-3.2.2,yarn-3.2.2,zookeeper-3.6.1,openldap-2.4.44,knox-1.2.0</li><li>ProductId为34(EMR-V3.3.0)的时候，必选组件包括：hdfs-3.2.2,yarn-3.2.2,zookeeper-3.6.1,openldap-2.4.44,knox-1.2.0</li><li>ProductId为37(EMR-V3.4.0)的时候，必选组件包括：hdfs-3.2.2,yarn-3.2.2,zookeeper-3.6.3,openldap-2.4.44,knox-1.6.1</li><li>ProductId为44(EMR-V3.5.0)的时候，必选组件包括：hdfs-3.2.2,yarn-3.2.2,zookeeper-3.6.3,openldap-2.4.44,knox-1.6.1</li><li>ProductId为53(EMR-V3.6.0)的时候，必选组件包括：hdfs-3.2.2,yarn-3.2.2,zookeeper-3.6.3,openldap-2.4.44,knox-1.6.1</li><li>ProductId为58(EMR-V3.6.1)的时候，必选组件包括：hdfs-3.2.2,yarn-3.2.2,zookeeper-3.6.3,openldap-2.4.46,knox-1.6.1</li><li>ProductId为47(EMR-V4.0.0)的时候，必选组件包括：hdfs-3.2.2,yarn-3.2.2,zookeeper-3.6.3,openldap-2.4.44,knox-1.6.1</li>
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// 询价的节点规格。
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NewResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// 实例所在的位置。通过该参数可以指定实例所属可用区，所属项目等属性。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 私有网络相关信息配置。通过该参数可以指定私有网络的ID，子网ID等信息。
        /// </summary>
        [JsonProperty("VPCSettings")]
        public VPCSettings VPCSettings{ get; set; }

        /// <summary>
        /// hive共享元数据库类型。取值范围：
        /// <li>EMR_NEW_META：表示集群默认创建</li>
        /// <li>EMR_EXIT_METE：表示集群使用指定EMR-MetaDB。</li>
        /// <li>USER_CUSTOM_META：表示集群使用自定义MetaDB。</li>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// EMR-MetaDB实例
        /// </summary>
        [JsonProperty("UnifyMetaInstanceId")]
        public string UnifyMetaInstanceId{ get; set; }

        /// <summary>
        /// 自定义MetaDB信息
        /// </summary>
        [JsonProperty("MetaDBInfo")]
        public CustomMetaInfo MetaDBInfo{ get; set; }

        /// <summary>
        /// 产品ID，不同产品ID表示不同的EMR产品版本。取值范围：<li>2：表示EMR-V2.0.1</li><li>16：表示EMR-V2.3.0</li><li>20：表示EMR-V2.5.0</li><li>30：表示EMR-V2.6.0</li><li>38：表示EMR-V2.7.0</li><li>57：表示EMR-V2.8.0</li><li>7：表示EMR-V3.0.0</li><li>25：表示EMR-V3.1.0</li><li>31：表示EMR-V3.1.1</li><li>28：表示EMR-V3.2.0</li><li>33：表示EMR-V3.2.1</li><li>34：表示EMR-V3.3.0</li><li>37：表示EMR-V3.4.0</li><li>44：表示EMR-V3.5.0</li><li>53：表示EMR-V3.6.0</li><li>58：表示EMR-V3.6.1</li><li>47：表示EMR-V4.0.0</li>
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// 场景化取值：Hadoop-Kudu，Hadoop-Zookeeper，Hadoop-Presto，Hadoop-Hbase
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// 共用组件信息
        /// </summary>
        [JsonProperty("ExternalService")]
        public ExternalService[] ExternalService{ get; set; }

        /// <summary>
        /// 当前默认值为0，跨AZ特性支持后为1
        /// </summary>
        [JsonProperty("VersionID")]
        public ulong? VersionID{ get; set; }

        /// <summary>
        /// 可用区的规格信息
        /// </summary>
        [JsonProperty("MultiZoneSettings")]
        public MultiZoneSetting[] MultiZoneSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "SupportHA", this.SupportHA);
            this.SetParamArraySimple(map, prefix + "Software.", this.Software);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamObj(map, prefix + "VPCSettings.", this.VPCSettings);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "UnifyMetaInstanceId", this.UnifyMetaInstanceId);
            this.SetParamObj(map, prefix + "MetaDBInfo.", this.MetaDBInfo);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamArrayObj(map, prefix + "ExternalService.", this.ExternalService);
            this.SetParamSimple(map, prefix + "VersionID", this.VersionID);
            this.SetParamArrayObj(map, prefix + "MultiZoneSettings.", this.MultiZoneSettings);
        }
    }
}

