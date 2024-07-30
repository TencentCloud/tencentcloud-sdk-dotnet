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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGoodsDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作类型，“CREATE"表示创建、”MODIFY"表示变更配置、“RENEW"表示续费
        /// </summary>
        [JsonProperty("Case")]
        public string Case{ get; set; }

        /// <summary>
        /// 可用区，例如"ap-guangzhou-3"表示广州三区等
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 集群的高可用标记，true表示为高可用集群
        /// </summary>
        [JsonProperty("HaFlag")]
        public bool? HaFlag{ get; set; }

        /// <summary>
        /// 高可用类型： 0：非高可用 1：读高可用 2：读写高可用。	
        /// </summary>
        [JsonProperty("HaType")]
        public long? HaType{ get; set; }

        /// <summary>
        /// 用户集群的私有网络
        /// </summary>
        [JsonProperty("UserVPCId")]
        public string UserVPCId{ get; set; }

        /// <summary>
        /// 用户集群的子网
        /// </summary>
        [JsonProperty("UserSubnetId")]
        public string UserSubnetId{ get; set; }

        /// <summary>
        /// 用户集群的版本，例如“20.7.2.30”等
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// 集群ID，创建时为空，其他情况必须存在
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 集群资源规格描述
        /// </summary>
        [JsonProperty("Resources")]
        public ResourceNodeSpec[] Resources{ get; set; }

        /// <summary>
        /// 集群规格修改参数
        /// </summary>
        [JsonProperty("ModifySpec")]
        public ResourceNodeSpec ModifySpec{ get; set; }

        /// <summary>
        /// 计费信息
        /// </summary>
        [JsonProperty("ChargeProperties")]
        public ChargeProperties ChargeProperties{ get; set; }

        /// <summary>
        /// 创建集群时需要填写InstanceName
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 购买页填写的标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// CLS日志集ID
        /// </summary>
        [JsonProperty("ClsLogSetId")]
        public string ClsLogSetId{ get; set; }

        /// <summary>
        /// 用户子网剩余ip数量
        /// </summary>
        [JsonProperty("UserSubnetIPNum")]
        public long? UserSubnetIPNum{ get; set; }

        /// <summary>
        /// COS桶名称
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// 按量计费转包年包月
        /// </summary>
        [JsonProperty("HourToPrepaid")]
        public bool? HourToPrepaid{ get; set; }

        /// <summary>
        /// base64密码
        /// </summary>
        [JsonProperty("DorisUserPwd")]
        public string DorisUserPwd{ get; set; }

        /// <summary>
        /// 日志的类型，es或者cls_topic
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 表名大小写是否敏感，0：敏感；1：不敏感，表名改为以小写存储；2：不敏感，以小写进行比较
        /// </summary>
        [JsonProperty("CaseSensitive")]
        public long? CaseSensitive{ get; set; }

        /// <summary>
        /// true为滚动重启 false为批量重启
        /// </summary>
        [JsonProperty("RollingRestart")]
        public bool? RollingRestart{ get; set; }

        /// <summary>
        /// 是否为多可用区
        /// </summary>
        [JsonProperty("EnableMultiZones")]
        public bool? EnableMultiZones{ get; set; }

        /// <summary>
        /// 用户多可用区的网络信息
        /// </summary>
        [JsonProperty("UserMultiZoneInfos")]
        public NetworkInfo[] UserMultiZoneInfos{ get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("Details")]
        public InstanceDetail Details{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Case", this.Case);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "HaFlag", this.HaFlag);
            this.SetParamSimple(map, prefix + "HaType", this.HaType);
            this.SetParamSimple(map, prefix + "UserVPCId", this.UserVPCId);
            this.SetParamSimple(map, prefix + "UserSubnetId", this.UserSubnetId);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamObj(map, prefix + "ModifySpec.", this.ModifySpec);
            this.SetParamObj(map, prefix + "ChargeProperties.", this.ChargeProperties);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ClsLogSetId", this.ClsLogSetId);
            this.SetParamSimple(map, prefix + "UserSubnetIPNum", this.UserSubnetIPNum);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "HourToPrepaid", this.HourToPrepaid);
            this.SetParamSimple(map, prefix + "DorisUserPwd", this.DorisUserPwd);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "CaseSensitive", this.CaseSensitive);
            this.SetParamSimple(map, prefix + "RollingRestart", this.RollingRestart);
            this.SetParamSimple(map, prefix + "EnableMultiZones", this.EnableMultiZones);
            this.SetParamArrayObj(map, prefix + "UserMultiZoneInfos.", this.UserMultiZoneInfos);
            this.SetParamObj(map, prefix + "Details.", this.Details);
        }
    }
}

