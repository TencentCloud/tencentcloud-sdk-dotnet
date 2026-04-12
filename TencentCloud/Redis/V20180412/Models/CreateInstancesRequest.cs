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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例类型。</p><ul><li>2：Redis 2.8 内存版（标准架构）。</li><li>3：CKV 3.2 内存版（标准架构）。</li><li>4：CKV 3.2 内存版（集群架构）。</li><li>6：Redis 4.0 内存版（标准架构）。</li><li>7：Redis 4.0 内存版（集群架构）。</li><li>8：Redis 5.0 内存版（标准架构）。</li><li>9：Redis 5.0 内存版（集群架构）。</li><li>15：Redis 6.2 内存版（标准架构）。</li><li>16：Redis 6.2 内存版（集群架构）。</li><li>17：Redis 7.0 内存版（标准架构）。</li><li>18：Redis 7.0 内存版（集群架构）。</li><li>19：Valkey 8.0 内存版（标准架构）。</li><li>20：Valkey 8.0 内存版（集群架构）。</li><li>200：Memcached 1.6 内存版（集群架构）。<br><strong>说明</strong>：CKV 版本当前有存量用户使用，暂时保留。</li></ul>
        /// </summary>
        [JsonProperty("TypeId")]
        public ulong? TypeId{ get; set; }

        /// <summary>
        /// <p>内存容量，单位为MB， 数值需为1024的整数倍。具体规格，请通过 <a href="https://cloud.tencent.com/document/api/239/30600">DescribeProductInfo</a> 接口查询全地域的售卖规格。</p><ul><li><strong>TypeId</strong>为标准架构时，<strong>MemSize</strong>是实例总内存容量；</li><li><strong>TypeId</strong>为集群架构时，<strong>MemSize</strong>是单分片内存容量。</li></ul>
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// <p>实例数量，单次购买实例数量。具体信息，请通过 <a href="https://cloud.tencent.com/document/api/239/30600">DescribeProductInfo</a> 接口查询全地域的售卖规格。</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// <p>购买实例的时长。</p><ul><li>若 <strong>BillingMode</strong>为<strong>1</strong>，即计费方式为包年包月时，需设置该参数，指定所购买实例的时长。单位：月，取值范围 [1,2,3,4,5,6,7,8,9,10,11,12,24,36]。</li><li>若 <strong>BillingMode</strong>为<strong>0</strong>，即计费方式为按量计费时，该参数配置为1。</li></ul>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>计费方式。</p><ul><li>0：按量计费。</li><li>1：包年包月。</li></ul>
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// <p>实例所属的可用区ID，可参考<a href="https://cloud.tencent.com/document/product/239/4106">地域和可用区</a>  。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// <p>访问实例的密码。</p><ul><li>当输入参数<strong>NoAuth</strong>为<strong>true</strong>时，指设置实例为免密码访问，Password可不用配置，否则Password为必填参数。</li><li>当实例类型<strong>TypeId</strong>为Redis 2.8 内存版标准架构、Redis 4.0、5.0、6.2、7.0内存版标准架构或集群架构时，其密码复杂度要求为：8-64个字符，至少包含小写字母、大写字母、数字和字符()`~!@#$%^&amp;*-+=_|{}[]:;&lt;&gt;,.?/ 中的2种，不能以&quot;/&quot;开头。</li><li>当实例类型<strong>TypeId</strong>为CKV 3.2 内存版标准架构或集群架构时，其密码复杂度为：8-30个字符，必须包含字母和数字，且不包含其他字符。</li></ul>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>私有网络ID。如果不配置该参数则默认选择基础网络。请登录 <a href="https://console.cloud.tencent.com/vpc">私有网络</a>控制台查询具体的ID。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>私有网络VPC的子网。基础网络下， 该参数无需配置。请登录 <a href="https://console.cloud.tencent.com/vpc">私有网络</a>控制台查询子网列表获取具体的 ID。</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>项目 ID。请登录<a href="https://console.cloud.tencent.com/redis#/">Redis控制台</a>，在右上角的账户信息菜单中，选择<strong>项目管理</strong>查询项目 ID。</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>自动续费标识。</p><ul><li>0：默认状态（手动续费）。</li><li>1：自动续费。</li><li>2：到期不续费。</li></ul>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// <p>安全组 ID 数组。</p><ul><li>安全组是一种虚拟防火墙，对云数据库实例的网络访问进行控制。创建实例时，建议绑定相应的安全组。</li><li>请通过 <a href="https://cloud.tencent.com/document/product/239/34447">DescribeInstanceSecurityGroup</a> 接口获取实例的安全组 ID。</li></ul>
        /// </summary>
        [JsonProperty("SecurityGroupIdList")]
        public string[] SecurityGroupIdList{ get; set; }

        /// <summary>
        /// <p>用户自定义的网络端口。默认为6379，范围为 [1024,65535]。</p>
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// <p>实例分片数量。</p><ul><li>标准版实例无需配置该参数。</li><li>集群版实例，分片数量范围为：[1、3、5、8、12、16、24、32、40、48、64、80、96、128]。</li></ul>
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public long? RedisShardNum{ get; set; }

        /// <summary>
        /// <p>实例副本数量。</p><ul><li>Redis 内存版 4.0、5.0、6.2、7.0 标准架构和集群架构支持副本数量范围为[1,5]。</li><li>Redis 2.8标准版、CKV标准版只支持1副本。</li></ul>
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public long? RedisReplicasNum{ get; set; }

        /// <summary>
        /// <p>标识实例是否需支持副本只读。</p><ul><li>Redis 2.8 标准版、CKV标准版不支持副本只读。</li><li>开启副本只读，实例将自动读写分离，写请求路由到主节点，读请求路由到副本节点。</li><li>如需开启副本只读，建议副本数量大于等于2。</li></ul>
        /// </summary>
        [JsonProperty("ReplicasReadonly")]
        public bool? ReplicasReadonly{ get; set; }

        /// <summary>
        /// <p>实例名称。命名要求：仅支持长度小于60的中文、英文或者数字，短划线&quot;-&quot;、下划线&quot;_&quot;。</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>配置实例是否支持免密码访问。</p><ul><li>true：免密访问实例。</li><li>false：非免密访问实例。默认为非免密方式，仅VPC网络的实例支持免密码访问。</li></ul>
        /// </summary>
        [JsonProperty("NoAuth")]
        public bool? NoAuth{ get; set; }

        /// <summary>
        /// <p>实例的节点信息，包含节点 ID、节点类型、节点可用区 ID等。具体信息，请参见<a href="https://cloud.tencent.com/document/product/239/20022">RedisNodeInfo </a>。<br>目前支持传入节点的类型（主节点或者副本节点），节点的可用区。未指定该参数时，在支持多可用区部署的地域，系统将默认创建多可用区架构实例。</p>
        /// </summary>
        [JsonProperty("NodeSet")]
        public RedisNodeInfo[] NodeSet{ get; set; }

        /// <summary>
        /// <p>给实例设定标签。</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>指定实例所属的可用区名称。具体信息，请参见<a href="https://cloud.tencent.com/document/product/239/4106">地域和可用区</a>  。</p>
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// <p>指定实例相关的参数模板 ID。</p><ul><li>若不配置该参数，则系统会依据所选择的兼容版本及架构，自动适配对应的默认模板。</li><li>请通过<a href="https://cloud.tencent.com/document/product/239/58750">DescribeParamTemplates</a>接口，查询实例的参数模板列表，获取模板 ID 编号。</li></ul>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>内部参数，标识创建实例是否需要检查。</p><ul><li>false ：默认值。发送正常请求，通过检查后直接创建实例。</li><li>true：发送检查请求，不会创建实例。</li></ul>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>指实例部署模式。</p><ul><li>local：传统架构，默认为 local。</li><li>cdc：独享集群。</li><li>cloud：云原生，当前已暂停售卖。</li></ul>
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// <p>独享集群 ID。</p><ul><li>当 <strong>ProductVersion</strong> 设置为 <strong>cdc</strong> 时，该参数必须设置。</li><li>请通过接口<a href="https://cloud.tencent.com/document/product/239/109628"> DescribeRedisClusters</a> 获取集群 ID。</li></ul>
        /// </summary>
        [JsonProperty("RedisClusterId")]
        public string RedisClusterId{ get; set; }

        /// <summary>
        /// <p>告警策略 ID 数组。</p><ul><li>请登录<a href="https://console.cloud.tencent.com/monitor/alarm/policy">腾讯云可观测平台-告警管理-策略管理</a>获取告警策略 ID。</li><li>若不配置该参数，则绑定默认告警策略。默认告警策略具体信息，请登录<a href="https://console.cloud.tencent.com/monitor/alarm/policy">腾讯云可观测平台-告警管理-策略管理</a>查看。</li></ul>
        /// </summary>
        [JsonProperty("AlarmPolicyList")]
        public string[] AlarmPolicyList{ get; set; }

        /// <summary>
        /// <p>是否加密密码</p>
        /// </summary>
        [JsonProperty("EncryptPassword")]
        public bool? EncryptPassword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIdList.", this.SecurityGroupIdList);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "RedisShardNum", this.RedisShardNum);
            this.SetParamSimple(map, prefix + "RedisReplicasNum", this.RedisReplicasNum);
            this.SetParamSimple(map, prefix + "ReplicasReadonly", this.ReplicasReadonly);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "NoAuth", this.NoAuth);
            this.SetParamArrayObj(map, prefix + "NodeSet.", this.NodeSet);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamSimple(map, prefix + "RedisClusterId", this.RedisClusterId);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyList.", this.AlarmPolicyList);
            this.SetParamSimple(map, prefix + "EncryptPassword", this.EncryptPassword);
        }
    }
}

