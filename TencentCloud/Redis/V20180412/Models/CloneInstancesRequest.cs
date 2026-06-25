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

    public class CloneInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指定待克隆的源实例 ID。例如：crs-xjhsdj****。请登录<a href="https://console.cloud.tencent.com/redis">Redis控制台</a>在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>单次克隆实例的数量。</p><ul><li>包年包月每次购买最大数量为100。</li><li>按量计费每次购买最大数量为30。</li></ul>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// <p>克隆实例所属的可用区ID。当前所支持的可用区 ID，请参见<a href="https://cloud.tencent.com/document/product/239/4106">地域和可用区</a> 。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// <p>付费方式。<ul><li>0：按量计费。</li><li>1：包年包月。</li></ul></p>
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// <p>购买实例时长。<ul><li>单位：月。</li><li>付费方式选择包年包月计费时，取值范围为[1,2,3,4,5,6,7,8,9,10,11,12,24,36,48,60]。</li><li>付费方式选择按量计费时，设置为1。</li></ul></p>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>安全组ID。请通过 <a href="https://cloud.tencent.com/document/product/239/34447">DescribeInstanceSecurityGroup</a> 接口获取实例的安全组 ID。</p>
        /// </summary>
        [JsonProperty("SecurityGroupIdList")]
        public string[] SecurityGroupIdList{ get; set; }

        /// <summary>
        /// <p>克隆实例使用的备份ID。请通过接口<a href="https://cloud.tencent.com/document/product/239/20011">DescribeInstanceBackups</a>获取备份ID。</p>
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// <p>配置克隆实例是否支持免密访问。开启 SSL 与外网均不支持免密访问。<ul><li>true：免密实例，</li><li>false：非免密实例。默认为非免密实例。</li></ul></p>
        /// </summary>
        [JsonProperty("NoAuth")]
        public bool? NoAuth{ get; set; }

        /// <summary>
        /// <p>配置克隆实例的私有网络ID。如果未配置该参数，默认选择基础网络。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>配置克隆实例所属私有网络的子网。基础网络时该参数无需配置。</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>克隆实例的名称。<br>仅支持长度小于60的中文、英文或者数字，短划线&quot;-&quot;、下划线&quot;_&quot;。<br></p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>克隆实例的访问密码。<ul><li>当输入参数<b>NoAuth</b>为<b>true</b>时，可不设置该参数。</li><li>当实例为Redis2.8、4.0和5.0时，其密码格式为：8-30个字符，至少包含小写字母、大写字母、数字和字符 ()`~!@#$%^&amp;*-+=_|{}[]:;&lt;&gt;,.?/ 中的2种，不能以&quot;/&quot;开头；</li><li>当实例为CKV 3.2时，其密码格式为：8-30个字符，必须包含字母和数字，且不包含其他字符。</li></ul></p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>自动续费标识。<ul><li>0：默认状态，手动续费。</li><li>1：自动续费。</li><li>2：不自动续费，到期自动隔离。</li></ul></p>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// <p>用户自定义的端口，默认为6379，取值范围[1024,65535]。</p>
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// <p>实例的节点信息。<ul><li>目前支持配置节点的类型（主节点或者副本节点），及其节点的可用区信息。具体信息，请参见<a href="https://cloud.tencent.com/document/product/239/20022#RedisNodeInfo">RedisNodeInfo</a>。</li><li>单可用区部署可不配置该参数。</li></ul></p>
        /// </summary>
        [JsonProperty("NodeSet")]
        public RedisNodeInfo[] NodeSet{ get; set; }

        /// <summary>
        /// <p>项目 ID。登录<a href="https://console.cloud.tencent.com/redis#/">Redis 控制台</a>，可在右上角的<b>账号中心</b> &gt; <b>项目管理</b>中查找项目ID。</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>克隆实例需绑定的标签。</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>指定克隆实例相关的参数模板 ID。</p><ul><li>若不配置该参数，则系统会依据所选择的兼容版本及架构，自动适配对应的默认模板。</li><li>请通过<a href="https://cloud.tencent.com/document/product/239/58750">DescribeParamTemplates</a>接口，查询实例的参数模板列表，获取模板 ID 编号。</li></ul>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>指定克隆实例的告警策略 ID。请登录<a href="https://console.cloud.tencent.com/monitor/alarm2/policy">腾讯云可观测平台控制台</a>，在 <b>告警管理</b> &gt; <b>策略管理</b>页面获取策略 ID 信息。</p>
        /// </summary>
        [JsonProperty("AlarmPolicyList")]
        public string[] AlarmPolicyList{ get; set; }

        /// <summary>
        /// <p>克隆指定恢复数据的时间。<br>仅支持已开通秒级备份的实例</p>
        /// </summary>
        [JsonProperty("CloneTime")]
        public string CloneTime{ get; set; }

        /// <summary>
        /// <p>是否加密密码</p>
        /// </summary>
        [JsonProperty("EncryptPassword")]
        public bool? EncryptPassword{ get; set; }

        /// <summary>
        /// <p>实例密码复杂度策略</p><p>入参限制：未传或 Enabled=false 视为不启用，按默认规则校验</p>
        /// </summary>
        [JsonProperty("PasswordPolicy")]
        public PasswordPolicy PasswordPolicy{ get; set; }

        /// <summary>
        /// <p>是否开启 SSL 加密传输。</p><p>枚举值：</p><ul><li>true： 开启。</li><li>false： 关闭（默认值）。</li></ul><p>默认值：false</p>
        /// </summary>
        [JsonProperty("EnableSSL")]
        public bool? EnableSSL{ get; set; }

        /// <summary>
        /// <p>开启 SSL 时，是否将实例的内网 IPv4 地址写入证书的域名别名（SAN）中。仅在 EnableSSL 为 true 时生效。</p><p>枚举值：</p><ul><li>true： 允许使用内网 IP 进行 SSL 证书校验。</li><li>false： 不添加证书的 SAN 扩展信息。</li></ul><p>默认值：false</p>
        /// </summary>
        [JsonProperty("SSLBindPrivateIPv4")]
        public bool? SSLBindPrivateIPv4{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIdList.", this.SecurityGroupIdList);
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "NoAuth", this.NoAuth);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamArrayObj(map, prefix + "NodeSet.", this.NodeSet);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyList.", this.AlarmPolicyList);
            this.SetParamSimple(map, prefix + "CloneTime", this.CloneTime);
            this.SetParamSimple(map, prefix + "EncryptPassword", this.EncryptPassword);
            this.SetParamObj(map, prefix + "PasswordPolicy.", this.PasswordPolicy);
            this.SetParamSimple(map, prefix + "EnableSSL", this.EnableSSL);
            this.SetParamSimple(map, prefix + "SSLBindPrivateIPv4", this.SSLBindPrivateIPv4);
        }
    }
}

