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
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 所属VPC网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 所属子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 数据库类型，取值范围: 
        /// <li> MYSQL </li>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// 数据库版本，取值范围: 
        /// <li> MYSQL可选值：5.7，8.0 </li>
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// 所属项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 当DbMode为NORMAL或不填时必选
        /// 普通实例Cpu核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 当DbMode为NORMAL或不填时必选
        /// 普通实例内存,单位GB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例数量，数量范围为(0,16]，默认值为2（即一个rw实例+一个ro实例），传递的n表示1个rw实例+n-1个ro实例（规格相同），如需要更精确的集群组成搭配，请使用InstanceInitInfos
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// 该参数无实际意义，已废弃。
        /// 存储大小，单位GB。
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 集群名称，长度小于64个字符，每个字符取值范围：大/小写字母，数字，特殊符号（'-','_','.'）
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 账号密码(8-64个字符，包含大小写英文字母、数字和符号~!@#$%^&*_-+=`|\(){}[]:;'<>,.?/中的任意三种)
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// 端口，默认3306，取值范围[0, 65535)
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 计费模式，按量计费：0，包年包月：1。默认按量计费。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 购买集群数，可选值范围[1,50]，默认为1
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 回档类型：
        /// noneRollback：不回档；
        /// snapRollback，快照回档；
        /// timeRollback，时间点回档
        /// </summary>
        [JsonProperty("RollbackStrategy")]
        public string RollbackStrategy{ get; set; }

        /// <summary>
        /// 快照回档，表示snapshotId；时间点回档，表示queryId，为0，表示需要判断时间点是否有效
        /// </summary>
        [JsonProperty("RollbackId")]
        public ulong? RollbackId{ get; set; }

        /// <summary>
        /// 回档时，传入源集群ID，用于查找源poolId
        /// </summary>
        [JsonProperty("OriginalClusterId")]
        public string OriginalClusterId{ get; set; }

        /// <summary>
        /// 时间点回档，指定时间；快照回档，快照时间
        /// </summary>
        [JsonProperty("ExpectTime")]
        public string ExpectTime{ get; set; }

        /// <summary>
        /// 该参数无实际意义，已废弃。
        /// 时间点回档，指定时间允许范围
        /// </summary>
        [JsonProperty("ExpectTimeThresh")]
        public ulong? ExpectTimeThresh{ get; set; }

        /// <summary>
        /// 普通实例存储上限，单位GB
        /// 当DbType为MYSQL，且存储计费模式为预付费时，该参数需不大于cpu与memory对应存储规格上限
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// 包年包月购买时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 包年包月购买时长单位，['s','d','m','y']
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 包年包月购买是否自动续费，默认为0。
        /// 0标识默认续费方式，1表示自动续费，2表示不自动续费。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 是否自动选择代金券 1是 0否 默认为0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// 实例数量（该参数已不再使用，只做存量兼容处理）
        /// </summary>
        [JsonProperty("HaCount")]
        public long? HaCount{ get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [JsonProperty("OrderSource")]
        public string OrderSource{ get; set; }

        /// <summary>
        /// 集群创建需要绑定的tag数组信息
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// Db类型
        /// 当DbType为MYSQL时可选(默认NORMAL)：
        /// <li>NORMAL</li>
        /// <li>SERVERLESS</li>
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// 当DbMode为SERVERLESS时必填
        /// cpu最小值，可选范围参考DescribeServerlessInstanceSpecs接口返回
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// 当DbMode为SERVERLESS时必填：
        /// cpu最大值，可选范围参考DescribeServerlessInstanceSpecs接口返回
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// 当DbMode为SERVERLESS时，指定集群是否自动暂停，可选范围
        /// <li>yes</li>
        /// <li>no</li>
        /// 默认值:yes
        /// </summary>
        [JsonProperty("AutoPause")]
        public string AutoPause{ get; set; }

        /// <summary>
        /// 当DbMode为SERVERLESS时，指定集群自动暂停的延迟，单位秒，可选范围[600,691200]
        /// 默认值:600
        /// </summary>
        [JsonProperty("AutoPauseDelay")]
        public long? AutoPauseDelay{ get; set; }

        /// <summary>
        /// 集群存储计费模式，按量计费：0，包年包月：1。默认按量计费
        /// 当DbType为MYSQL时，在集群计算计费模式为后付费（包括DbMode为SERVERLESS）时，存储计费模式仅可为按量计费
        /// 回档与克隆均不支持包年包月存储
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public long? StoragePayMode{ get; set; }

        /// <summary>
        /// 安全组id数组
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 告警策略Id数组
        /// </summary>
        [JsonProperty("AlarmPolicyIds")]
        public string[] AlarmPolicyIds{ get; set; }

        /// <summary>
        /// 参数数组，暂时支持character_set_server （utf8｜latin1｜gbk｜utf8mb4） ，lower_case_table_names，1-大小写不敏感，0-大小写敏感
        /// </summary>
        [JsonProperty("ClusterParams")]
        public ParamItem[] ClusterParams{ get; set; }

        /// <summary>
        /// 交易模式，0-下单且支付，1-下单
        /// </summary>
        [JsonProperty("DealMode")]
        public long? DealMode{ get; set; }

        /// <summary>
        /// 参数模板ID，可以通过查询参数模板信息DescribeParamTemplates获得参数模板ID
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// 多可用区地址
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// 实例初始化配置信息，主要用于购买集群时选不同规格实例
        /// </summary>
        [JsonProperty("InstanceInitInfos")]
        public InstanceInitInfo[] InstanceInitInfos{ get; set; }

        /// <summary>
        /// 全球数据库唯一标识
        /// </summary>
        [JsonProperty("GdnId")]
        public string GdnId{ get; set; }

        /// <summary>
        /// 数据库代理配置
        /// </summary>
        [JsonProperty("ProxyConfig")]
        public ProxyConfig ProxyConfig{ get; set; }

        /// <summary>
        /// 是否自动归档
        /// </summary>
        [JsonProperty("AutoArchive")]
        public string AutoArchive{ get; set; }

        /// <summary>
        /// 暂停后的归档处理时间
        /// </summary>
        [JsonProperty("AutoArchiveDelayHours")]
        public long? AutoArchiveDelayHours{ get; set; }


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
        }
    }
}

