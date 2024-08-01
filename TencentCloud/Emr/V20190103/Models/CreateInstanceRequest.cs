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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID，不同产品ID表示不同的EMR产品版本。取值范围：
        /// 51:表示STARROCKS-V1.4.0
        /// 54:表示STARROCKS-V2.0.0
        /// 27:表示KAFKA-V1.0.0
        /// 50:表示KAFKA-V2.0.0
        /// 16:表示EMR-V2.3.0
        /// 20:表示EMR-V2.5.0
        /// 30:表示EMR-V2.6.0
        /// 38:表示EMR-V2.7.0
        /// 25:表示EMR-V3.1.0
        /// 33:表示EMR-V3.2.1
        /// 34:表示EMR-V3.3.0
        /// 37:表示EMR-V3.4.0
        /// 44:表示EMR-V3.5.0
        /// 53:表示EMR-V3.6.0
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// 部署的组件列表。不同的EMR产品ID（ProductId：具体含义参考入参ProductId字段）对应不同可选组件列表，不同产品版本可选组件列表查询：[组件版本](https://cloud.tencent.com/document/product/589/20279) ；
        /// 填写实例值：hive、flink。
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// 是否开启节点高可用。取值范围：
        /// <li>0：表示不开启节点高可用。</li>
        /// <li>1：表示开启节点高可用。</li>
        /// </summary>
        [JsonProperty("SupportHA")]
        public ulong? SupportHA{ get; set; }

        /// <summary>
        /// 实例名称。
        /// <li>长度限制为6-36个字符。</li>
        /// <li>只允许包含中文、字母、数字、-、_。</li>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例计费模式。取值范围：
        /// <li>0：表示按量计费。</li>
        /// <li>1：表示包年包月。</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 购买实例的时长。结合TimeUnit一起使用。
        /// <li>TimeUnit为s时，该参数只能填写3600，表示按量计费实例。</li>
        /// <li>TimeUnit为m时，该参数填写的数字表示包年包月实例的购买时长，如1表示购买一个月</li>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 购买实例的时间单位。取值范围：
        /// <li>s：表示秒。PayMode取值为0时，TimeUnit只能取值为s。</li>
        /// <li>m：表示月份。PayMode取值为1时，TimeUnit只能取值为m。</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 实例登录设置。通过该参数可以设置所购买节点的登录方式密码或者密钥。
        /// <li>设置密钥时，密码仅用于组件原生WebUI快捷入口登录。</li>
        /// <li>未设置密钥时，密码用于登录所购节点以及组件原生WebUI快捷入口登录。</li>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// 私有网络相关信息配置。通过该参数可以指定私有网络的ID，子网ID等信息。
        /// </summary>
        [JsonProperty("VPCSettings")]
        public VPCSettings VPCSettings{ get; set; }

        /// <summary>
        /// 节点资源的规格。
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NewResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// 开启COS访问需要设置的参数。
        /// </summary>
        [JsonProperty("COSSettings")]
        public COSSettings COSSettings{ get; set; }

        /// <summary>
        /// 实例所在的位置。通过该参数可以指定实例所属可用区，所属项目等属性。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 实例所属安全组的ID，形如sg-xxxxxxxx。该参数可以通过调用 [DescribeSecurityGroups](https://cloud.tencent.com/document/api/215/15808) 的返回值中的SecurityGroupId字段来获取。
        /// </summary>
        [JsonProperty("SgId")]
        public string SgId{ get; set; }

        /// <summary>
        /// [引导操作](https://cloud.tencent.com/document/product/589/35656)脚本设置。
        /// </summary>
        [JsonProperty("PreExecutedFileSettings")]
        public PreExecuteFileSettings[] PreExecutedFileSettings{ get; set; }

        /// <summary>
        /// 包年包月实例是否自动续费。取值范围：
        /// <li>0：表示不自动续费。</li>
        /// <li>1：表示自动续费。</li>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// 唯一随机标识，时效5分钟，需要调用者指定 防止客户端重新创建资源，例如 a9a90aa6-751a-41b6-aad6-fae36063280
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 是否开启集群Master节点公网。取值范围：
        /// <li>NEED_MASTER_WAN：表示开启集群Master节点公网。</li>
        /// <li>NOT_NEED_MASTER_WAN：表示不开启。</li>默认开启集群Master节点公网。
        /// </summary>
        [JsonProperty("NeedMasterWan")]
        public string NeedMasterWan{ get; set; }

        /// <summary>
        /// 是否需要开启外网远程登录，即22号端口。在SgId不为空时，该参数无效。
        /// </summary>
        [JsonProperty("RemoteLoginAtCreate")]
        public long? RemoteLoginAtCreate{ get; set; }

        /// <summary>
        /// 是否开启安全集群。0表示不开启，非0表示开启。
        /// </summary>
        [JsonProperty("CheckSecurity")]
        public long? CheckSecurity{ get; set; }

        /// <summary>
        /// 访问外部文件系统。
        /// </summary>
        [JsonProperty("ExtendFsField")]
        public string ExtendFsField{ get; set; }

        /// <summary>
        /// 标签描述列表。通过指定该参数可以同时绑定标签到相应的实例。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 分散置放群组ID列表，当前只支持指定一个。
        /// 该参数可以通过调用 [DescribeSecurityGroups](https://cloud.tencent.com/document/product/213/15486 ) 的返回值中的SecurityGroupId字段来获取。
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// 集群维度CBS加密盘，默认0表示不加密，1表示加密
        /// </summary>
        [JsonProperty("CbsEncrypt")]
        public ulong? CbsEncrypt{ get; set; }

        /// <summary>
        /// hive共享元数据库类型。取值范围：
        /// <li>EMR_DEFAULT_META：表示集群默认创建</li>
        /// <li>EMR_EXIST_META：表示集群使用指定EMR-MetaDB。</li>
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
        /// 自定义应用角色。
        /// </summary>
        [JsonProperty("ApplicationRole")]
        public string ApplicationRole{ get; set; }

        /// <summary>
        /// 场景化取值：
        /// Hadoop-Kudu
        /// Hadoop-Zookeeper
        /// Hadoop-Presto
        /// Hadoop-Hbase
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// 共享组件信息
        /// </summary>
        [JsonProperty("ExternalService")]
        public ExternalService[] ExternalService{ get; set; }

        /// <summary>
        /// 如果为0，则MultiZone、MultiDeployStrategy、MultiZoneSettings是disable的状态，如果为1，则废弃ResourceSpec，使用MultiZoneSettings。
        /// </summary>
        [JsonProperty("VersionID")]
        public long? VersionID{ get; set; }

        /// <summary>
        /// true表示开启跨AZ部署；仅为新建集群时的用户参数，后续不支持调整。
        /// </summary>
        [JsonProperty("MultiZone")]
        public bool? MultiZone{ get; set; }

        /// <summary>
        /// 节点资源的规格，有几个可用区，就填几个，按顺序第一个为主可用区，第二个为备可用区，第三个为仲裁可用区。如果没有开启跨AZ，则长度为1即可。
        /// </summary>
        [JsonProperty("MultiZoneSettings")]
        public MultiZoneSetting[] MultiZoneSettings{ get; set; }

        /// <summary>
        /// cos桶路径，创建StarRocks存算分离集群时用到
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamArraySimple(map, prefix + "Software.", this.Software);
            this.SetParamSimple(map, prefix + "SupportHA", this.SupportHA);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamObj(map, prefix + "VPCSettings.", this.VPCSettings);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamObj(map, prefix + "COSSettings.", this.COSSettings);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "SgId", this.SgId);
            this.SetParamArrayObj(map, prefix + "PreExecutedFileSettings.", this.PreExecutedFileSettings);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "NeedMasterWan", this.NeedMasterWan);
            this.SetParamSimple(map, prefix + "RemoteLoginAtCreate", this.RemoteLoginAtCreate);
            this.SetParamSimple(map, prefix + "CheckSecurity", this.CheckSecurity);
            this.SetParamSimple(map, prefix + "ExtendFsField", this.ExtendFsField);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "CbsEncrypt", this.CbsEncrypt);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "UnifyMetaInstanceId", this.UnifyMetaInstanceId);
            this.SetParamObj(map, prefix + "MetaDBInfo.", this.MetaDBInfo);
            this.SetParamSimple(map, prefix + "ApplicationRole", this.ApplicationRole);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamArrayObj(map, prefix + "ExternalService.", this.ExternalService);
            this.SetParamSimple(map, prefix + "VersionID", this.VersionID);
            this.SetParamSimple(map, prefix + "MultiZone", this.MultiZone);
            this.SetParamArrayObj(map, prefix + "MultiZoneSettings.", this.MultiZoneSettings);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
        }
    }
}

