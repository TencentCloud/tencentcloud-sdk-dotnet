/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDBInstanceHourRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例数量，默认值为1, 最小值1，最大值为100
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// 实例内存大小，单位：MB，请使用[获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229)接口获取可创建的内存规格
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例硬盘大小，单位：GB，请使用[获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229)接口获取可创建的硬盘范围
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// MySQL版本，值包括：5.5、5.6和5.7，请使用[获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229)接口获取可创建的实例版本
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// 私有网络ID，如果不传则默认选择基础网络，请使用[查询私有网络列表](/document/api/215/15778)
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 私有网络下的子网ID，如果设置了 UniqVpcId，则 UniqSubnetId 必填，请使用[查询子网列表](/document/api/215/15784)
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// 项目ID，不填为默认项目。请使用[查询项目列表](https://cloud.tencent.com/document/product/378/4400)接口获取项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 可用区信息，该参数缺省时，系统会自动选择一个可用区，请使用[获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229)接口获取可创建的可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例ID，购买只读实例或者灾备实例时必填，该字段表示只读实例或者灾备实例的主实例ID，请使用[查询实例列表](https://cloud.tencent.com/document/api/236/15872)接口查询云数据库实例ID
        /// </summary>
        [JsonProperty("MasterInstanceId")]
        public string MasterInstanceId{ get; set; }

        /// <summary>
        /// 实例类型，默认为 master，支持值包括：master-表示主实例，dr-表示灾备实例，ro-表示只读实例
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// 主实例的可用区信息，购买灾备实例时必填
        /// </summary>
        [JsonProperty("MasterRegion")]
        public string MasterRegion{ get; set; }

        /// <summary>
        /// 自定义端口，端口支持范围：[ 1024-65535 ]
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 设置root帐号密码，密码规则：8-64个字符，至少包含字母、数字、字符（支持的字符：_+-&=!@#$%^*()）中的两种，购买主实例时可指定该参数，购买只读实例或者灾备实例时指定该参数无意义
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 参数列表，参数格式如ParamList.0.Name=auto_increment&ParamList.0.Value=1。可通过[查询参数列表](/document/product/236/6369)查询支持设置的参数
        /// </summary>
        [JsonProperty("ParamList")]
        public ParamInfo[] ParamList{ get; set; }

        /// <summary>
        /// 数据复制方式，默认为0，支持值包括：0-表示异步复制，1-表示半同步复制，2-表示强同步复制，购买主实例时可指定该参数，购买只读实例或者灾备实例时指定该参数无意义
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// 多可用区域，默认为0，支持值包括：0-表示单可用区，1-表示多可用区，购买主实例时可指定该参数，购买只读实例或者灾备实例时指定该参数无意义
        /// </summary>
        [JsonProperty("DeployMode")]
        public long? DeployMode{ get; set; }

        /// <summary>
        /// 备库1的可用区ID，默认为zoneId的值，购买主实例时可指定该参数，购买只读实例或者灾备实例时指定该参数无意义
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// 备库2的可用区ID，默认为0，购买主实例时可指定该参数，购买只读实例或者灾备实例时指定该参数无意义
        /// </summary>
        [JsonProperty("BackupZone")]
        public string BackupZone{ get; set; }

        /// <summary>
        /// 安全组参数
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// 只读实例信息
        /// </summary>
        [JsonProperty("RoGroup")]
        public RoGroup RoGroup{ get; set; }

        /// <summary>
        /// 自动续费标记，值为0或1
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "MasterInstanceId", this.MasterInstanceId);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "MasterRegion", this.MasterRegion);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "ProtectMode", this.ProtectMode);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "SlaveZone", this.SlaveZone);
            this.SetParamSimple(map, prefix + "BackupZone", this.BackupZone);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamObj(map, prefix + "RoGroup.", this.RoGroup);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
        }
    }
}

