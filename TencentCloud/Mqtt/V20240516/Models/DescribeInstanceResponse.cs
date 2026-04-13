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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>实例类型<br>BASIC 基础版<br>PRO  专业版<br>PLATINUM 铂金版</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>主题数量</p>
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// <p>实例最大主题数量</p>
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// <p>TPS限流值</p>
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// <p>创建时间，秒为单位</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// <p>备注信息</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>实例状态， RUNNING, 运行中 MAINTAINING，维护中 ABNORMAL，异常 OVERDUE，欠费 DESTROYED，已删除 CREATING，创建中 MODIFYING，变配中 CREATE_FAILURE，创建失败 MODIFY_FAILURE，变配失败 DELETING，删除中</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>实例规格</p>
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// <p>单客户端最大订阅数</p>
        /// </summary>
        [JsonProperty("MaxSubscriptionPerClient")]
        public long? MaxSubscriptionPerClient{ get; set; }

        /// <summary>
        /// <p>授权规则条数</p>
        /// </summary>
        [JsonProperty("AuthorizationPolicyLimit")]
        public long? AuthorizationPolicyLimit{ get; set; }

        /// <summary>
        /// <p>客户端数量上限</p>
        /// </summary>
        [JsonProperty("ClientNumLimit")]
        public long? ClientNumLimit{ get; set; }

        /// <summary>
        /// <p>客户端证书注册方式：<br>JITP：自动注册<br>API：通过API手动注册</p>
        /// </summary>
        [JsonProperty("DeviceCertificateProvisionType")]
        public string DeviceCertificateProvisionType{ get; set; }

        /// <summary>
        /// <p>自动注册设备证书时是否自动激活</p>
        /// </summary>
        [JsonProperty("AutomaticActivation")]
        public bool? AutomaticActivation{ get; set; }

        /// <summary>
        /// <p>是否自动续费。仅包年包月集群生效。 1:自动续费 0:非自动续费</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>计费模式， POSTPAID，按量计费 PREPAID，包年包月</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>到期时间，毫秒级时间戳</p>
        /// </summary>
        [JsonProperty("ExpiryTime")]
        public long? ExpiryTime{ get; set; }

        /// <summary>
        /// <p>预销毁时间，毫秒级时间戳</p>
        /// </summary>
        [JsonProperty("DestroyTime")]
        public long? DestroyTime{ get; set; }

        /// <summary>
        /// <p>TLS,单向认证    mTLS,双向认证    BYOC;一机一证</p>
        /// </summary>
        [JsonProperty("X509Mode")]
        public string X509Mode{ get; set; }

        /// <summary>
        /// <p>最大Ca配额</p>
        /// </summary>
        [JsonProperty("MaxCaNum")]
        public long? MaxCaNum{ get; set; }

        /// <summary>
        /// <p>证书注册码</p>
        /// </summary>
        [JsonProperty("RegistrationCode")]
        public string RegistrationCode{ get; set; }

        /// <summary>
        /// <p>集群最大订阅数</p>
        /// </summary>
        [JsonProperty("MaxSubscription")]
        public long? MaxSubscription{ get; set; }

        /// <summary>
        /// <p>授权策略开关</p>
        /// </summary>
        [JsonProperty("AuthorizationPolicy")]
        public bool? AuthorizationPolicy{ get; set; }

        /// <summary>
        /// <p>共享订阅组数最大限制</p>
        /// </summary>
        [JsonProperty("SharedSubscriptionGroupLimit")]
        public long? SharedSubscriptionGroupLimit{ get; set; }

        /// <summary>
        /// <p>单个共享订阅组TopicFilter数限制</p>
        /// </summary>
        [JsonProperty("MaxTopicFilterPerSharedSubscriptionGroup")]
        [System.Obsolete]
        public long? MaxTopicFilterPerSharedSubscriptionGroup{ get; set; }

        /// <summary>
        /// <p>自动订阅规则条数限制</p>
        /// </summary>
        [JsonProperty("AutoSubscriptionPolicyLimit")]
        public long? AutoSubscriptionPolicyLimit{ get; set; }

        /// <summary>
        /// <p>单条自动订阅规则TopicFilter数限制</p>
        /// </summary>
        [JsonProperty("MaxTopicFilterPerAutoSubscriptionPolicy")]
        public long? MaxTopicFilterPerAutoSubscriptionPolicy{ get; set; }

        /// <summary>
        /// <p>是否使用默认的服务端证书</p>
        /// </summary>
        [JsonProperty("UseDefaultServerCert")]
        public bool? UseDefaultServerCert{ get; set; }

        /// <summary>
        /// <p>服务端CA最大数量</p>
        /// </summary>
        [JsonProperty("TrustedCaLimit")]
        public long? TrustedCaLimit{ get; set; }

        /// <summary>
        /// <p>服务端证书最大数量</p>
        /// </summary>
        [JsonProperty("ServerCertLimit")]
        public long? ServerCertLimit{ get; set; }

        /// <summary>
        /// <p>topic前缀最大层级</p>
        /// </summary>
        [JsonProperty("TopicPrefixSlashLimit")]
        public long? TopicPrefixSlashLimit{ get; set; }

        /// <summary>
        /// <p>单客户端发送消息限速，单位 条/秒</p>
        /// </summary>
        [JsonProperty("MessageRate")]
        public long? MessageRate{ get; set; }

        /// <summary>
        /// <p>服务端tls支持的协议，使用“,”分割。例如：TLSv1.3,TLSv1.2,TLSv1.1,TLSv1</p>
        /// </summary>
        [JsonProperty("TransportLayerSecurity")]
        public string TransportLayerSecurity{ get; set; }

        /// <summary>
        /// <p>消息属性增强规则配额</p>
        /// </summary>
        [JsonProperty("MessageEnrichmentRuleLimit")]
        public long? MessageEnrichmentRuleLimit{ get; set; }

        /// <summary>
        /// <p>封禁规则最大数量</p>
        /// </summary>
        [JsonProperty("BlockRuleLimit")]
        public long? BlockRuleLimit{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "TopicNumLimit", this.TopicNumLimit);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "MaxSubscriptionPerClient", this.MaxSubscriptionPerClient);
            this.SetParamSimple(map, prefix + "AuthorizationPolicyLimit", this.AuthorizationPolicyLimit);
            this.SetParamSimple(map, prefix + "ClientNumLimit", this.ClientNumLimit);
            this.SetParamSimple(map, prefix + "DeviceCertificateProvisionType", this.DeviceCertificateProvisionType);
            this.SetParamSimple(map, prefix + "AutomaticActivation", this.AutomaticActivation);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ExpiryTime", this.ExpiryTime);
            this.SetParamSimple(map, prefix + "DestroyTime", this.DestroyTime);
            this.SetParamSimple(map, prefix + "X509Mode", this.X509Mode);
            this.SetParamSimple(map, prefix + "MaxCaNum", this.MaxCaNum);
            this.SetParamSimple(map, prefix + "RegistrationCode", this.RegistrationCode);
            this.SetParamSimple(map, prefix + "MaxSubscription", this.MaxSubscription);
            this.SetParamSimple(map, prefix + "AuthorizationPolicy", this.AuthorizationPolicy);
            this.SetParamSimple(map, prefix + "SharedSubscriptionGroupLimit", this.SharedSubscriptionGroupLimit);
            this.SetParamSimple(map, prefix + "MaxTopicFilterPerSharedSubscriptionGroup", this.MaxTopicFilterPerSharedSubscriptionGroup);
            this.SetParamSimple(map, prefix + "AutoSubscriptionPolicyLimit", this.AutoSubscriptionPolicyLimit);
            this.SetParamSimple(map, prefix + "MaxTopicFilterPerAutoSubscriptionPolicy", this.MaxTopicFilterPerAutoSubscriptionPolicy);
            this.SetParamSimple(map, prefix + "UseDefaultServerCert", this.UseDefaultServerCert);
            this.SetParamSimple(map, prefix + "TrustedCaLimit", this.TrustedCaLimit);
            this.SetParamSimple(map, prefix + "ServerCertLimit", this.ServerCertLimit);
            this.SetParamSimple(map, prefix + "TopicPrefixSlashLimit", this.TopicPrefixSlashLimit);
            this.SetParamSimple(map, prefix + "MessageRate", this.MessageRate);
            this.SetParamSimple(map, prefix + "TransportLayerSecurity", this.TransportLayerSecurity);
            this.SetParamSimple(map, prefix + "MessageEnrichmentRuleLimit", this.MessageEnrichmentRuleLimit);
            this.SetParamSimple(map, prefix + "BlockRuleLimit", this.BlockRuleLimit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

