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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>可用区</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>所属VPC网络ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>所属子网ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>数据库类型</p><p>枚举值：</p><ul><li>MYSQL： MYSQL</li></ul>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// <p>数据库版本</p><p>枚举值：</p><ul><li>5.7： MySQL5.7版本</li><li>8.0： MySQL8.0版本</li></ul>
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// <p>所属项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>当DbMode为NORMAL或不填时必选<br>普通实例Cpu核数</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>当DbMode为NORMAL或不填时必选<br>普通实例内存,单位GB</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>实例数量</p><p>取值范围：[1, 16]</p><p>默认值：2</p><ul><li>取值为2，表示一个 rw 实例 + 一个 ro 实例。</li><li>传递的 n 表示1个 rw 实例 + n-1个 ro 实例（规格相同）。</li><li>如需要更精确的集群组成搭配，请使用 InstanceInitInfos。</li><li>此参数设置的数值适用于预置资源集群，如需设置 Serverless 集群的实例规格及数量，请使用 InstanceInitInfos.N 中的 InstanceInitInfo 结构。</li></ul>
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// <p>该参数无实际意义，已废弃。<br>存储大小，单位GB。</p>
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// <p>集群名称，长度小于64个字符，每个字符取值范围：大/小写字母，数字，特殊符号（&#39;-&#39;,&#39;_&#39;,&#39;.&#39;）</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>账号密码(8-64个字符，包含大小写英文字母、数字和符号~!@#$%^&amp;*_-+=`|(){}[]:;&#39;&lt;&gt;,.?/中的任意三种)</p>
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// <p>端口，默认3306，取值范围[0, 65535)</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>计费模式</p><p>枚举值：</p><ul><li>0： 表示按量计费</li><li>1： 表示包年包月</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>购买集群数，可选值范围[1,50]，默认为1</p>
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>回档类型</p><p>枚举值：</p><ul><li>noneRollback： 不回档</li><li>snapRollback： 快照回档</li><li>timeRollback： 时间点回档</li></ul>
        /// </summary>
        [JsonProperty("RollbackStrategy")]
        public string RollbackStrategy{ get; set; }

        /// <summary>
        /// <p>快照回档，表示snapshotId；时间点回档，表示queryId，为0，表示需要判断时间点是否有效</p>
        /// </summary>
        [JsonProperty("RollbackId")]
        public ulong? RollbackId{ get; set; }

        /// <summary>
        /// <p>回档时，传入源集群ID，用于查找源poolId</p>
        /// </summary>
        [JsonProperty("OriginalClusterId")]
        public string OriginalClusterId{ get; set; }

        /// <summary>
        /// <p>时间点回档，指定时间；快照回档，快照时间</p>
        /// </summary>
        [JsonProperty("ExpectTime")]
        public string ExpectTime{ get; set; }

        /// <summary>
        /// <p>该参数无实际意义，已废弃。<br>时间点回档，指定时间允许范围</p>
        /// </summary>
        [JsonProperty("ExpectTimeThresh")]
        public ulong? ExpectTimeThresh{ get; set; }

        /// <summary>
        /// <p>普通实例存储上限，单位GB<br>当DbType为MYSQL，且存储计费模式为预付费时，该参数需不大于cpu与memory对应存储规格上限</p>
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// <p>包年包月购买时长</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// <p>包年包月购买时长单位，[&#39;s&#39;,&#39;d&#39;,&#39;m&#39;,&#39;y&#39;]</p>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>包年包月购买是否自动续费</p><p>枚举值：</p><ul><li>0： 默认续费方式</li><li>1： 自动续费</li><li>2： 不自动续费</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>是否自动选择代金券 1是 0否 默认为0</p><p>枚举值：</p><ul><li>1： 是</li><li>0： 否</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// <p>实例数量（该参数已不再使用，只做存量兼容处理）</p>
        /// </summary>
        [JsonProperty("HaCount")]
        public long? HaCount{ get; set; }

        /// <summary>
        /// <p>订单来源</p>
        /// </summary>
        [JsonProperty("OrderSource")]
        public string OrderSource{ get; set; }

        /// <summary>
        /// <p>集群创建需要绑定的tag数组信息</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Db类型</p><p>枚举值：</p><ul><li>NORMAL： 普通实例</li><li>SERVERLESS： serverless实例</li></ul><p>默认值：NORMAL</p><p>当DbType为MYSQL时可选(默认NORMAL)</p>
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// <p>当DbMode为SERVERLESS时必填<br>cpu最小值，可选范围参考DescribeServerlessInstanceSpecs接口返回</p>
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// <p>当DbMode为SERVERLESS时必填：<br>cpu最大值，可选范围参考DescribeServerlessInstanceSpecs接口返回</p>
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// <p>否自动暂停</p><p>枚举值：</p><ul><li>yes： 是</li><li>no： 否</li></ul><p>默认值：yes</p><p>DbMode为SERVERLESS生效</p>
        /// </summary>
        [JsonProperty("AutoPause")]
        public string AutoPause{ get; set; }

        /// <summary>
        /// <p>当DbMode为SERVERLESS时，指定集群自动暂停的延迟，单位秒，可选范围[600,691200]<br>默认值:600</p>
        /// </summary>
        [JsonProperty("AutoPauseDelay")]
        public long? AutoPauseDelay{ get; set; }

        /// <summary>
        /// <p>集群存储计费模式，按量计费：0，包年包月：1。默认按量计费<br>当DbType为MYSQL时，在集群计算计费模式为后付费（包括DbMode为SERVERLESS）时，存储计费模式仅可为按量计费<br>回档与克隆均不支持包年包月存储</p>
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public long? StoragePayMode{ get; set; }

        /// <summary>
        /// <p>安全组id数组</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>告警策略Id数组</p>
        /// </summary>
        [JsonProperty("AlarmPolicyIds")]
        public string[] AlarmPolicyIds{ get; set; }

        /// <summary>
        /// <p>参数数组，暂时支持character_set_server （utf8｜latin1｜gbk｜utf8mb4） ，lower_case_table_names，1-大小写不敏感，0-大小写敏感</p>
        /// </summary>
        [JsonProperty("ClusterParams")]
        public ParamItem[] ClusterParams{ get; set; }

        /// <summary>
        /// <p>交易模式</p><p>枚举值：</p><ul><li>0： 下单且支付</li><li>1： 下单</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("DealMode")]
        public long? DealMode{ get; set; }

        /// <summary>
        /// <p>参数模板ID，可以通过查询参数模板信息DescribeParamTemplates获得参数模板ID</p>
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// <p>多可用区地址</p>
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// <p>实例初始化配置信息，主要用于购买集群时选不同规格实例</p>
        /// </summary>
        [JsonProperty("InstanceInitInfos")]
        public InstanceInitInfo[] InstanceInitInfos{ get; set; }

        /// <summary>
        /// <p>全球数据库唯一标识</p>
        /// </summary>
        [JsonProperty("GdnId")]
        public string GdnId{ get; set; }

        /// <summary>
        /// <p>数据库代理配置</p>
        /// </summary>
        [JsonProperty("ProxyConfig")]
        public ProxyConfig ProxyConfig{ get; set; }

        /// <summary>
        /// <p>是否自动归档</p><p>枚举值：</p><ul><li>yes： 是</li><li>no： 否</li></ul><p>默认值：no</p><p>仅当前集群主实例为SERVERLESS时，该参数生效</p>
        /// </summary>
        [JsonProperty("AutoArchive")]
        public string AutoArchive{ get; set; }

        /// <summary>
        /// <p>暂停后的归档处理时间</p><p>单位：时</p><p>默认值：12</p><p>仅当前集群主实例为SERVERLESS时，该参数生效</p>
        /// </summary>
        [JsonProperty("AutoArchiveDelayHours")]
        public long? AutoArchiveDelayHours{ get; set; }

        /// <summary>
        /// <p>集群级别，可空。例如 P0, P1。（可忽略该字段）</p>
        /// </summary>
        [JsonProperty("ClusterLevel")]
        public string ClusterLevel{ get; set; }

        /// <summary>
        /// <p>内核小版本号</p>
        /// </summary>
        [JsonProperty("CynosVersion")]
        public string CynosVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "RollbackStrategy", this.RollbackStrategy);
            this.SetParamSimple(map, prefix + "RollbackId", this.RollbackId);
            this.SetParamSimple(map, prefix + "OriginalClusterId", this.OriginalClusterId);
            this.SetParamSimple(map, prefix + "ExpectTime", this.ExpectTime);
            this.SetParamSimple(map, prefix + "ExpectTimeThresh", this.ExpectTimeThresh);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "HaCount", this.HaCount);
            this.SetParamSimple(map, prefix + "OrderSource", this.OrderSource);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "AutoPauseDelay", this.AutoPauseDelay);
            this.SetParamSimple(map, prefix + "StoragePayMode", this.StoragePayMode);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyIds.", this.AlarmPolicyIds);
            this.SetParamArrayObj(map, prefix + "ClusterParams.", this.ClusterParams);
            this.SetParamSimple(map, prefix + "DealMode", this.DealMode);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamSimple(map, prefix + "SlaveZone", this.SlaveZone);
            this.SetParamArrayObj(map, prefix + "InstanceInitInfos.", this.InstanceInitInfos);
            this.SetParamSimple(map, prefix + "GdnId", this.GdnId);
            this.SetParamObj(map, prefix + "ProxyConfig.", this.ProxyConfig);
            this.SetParamSimple(map, prefix + "AutoArchive", this.AutoArchive);
            this.SetParamSimple(map, prefix + "AutoArchiveDelayHours", this.AutoArchiveDelayHours);
            this.SetParamSimple(map, prefix + "ClusterLevel", this.ClusterLevel);
            this.SetParamSimple(map, prefix + "CynosVersion", this.CynosVersion);
        }
    }
}

