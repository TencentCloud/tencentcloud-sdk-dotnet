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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceInfo : AbstractModel
    {
        
        /// <summary>
        /// 设备唯一ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 设备状态ID，取值：<li>1：申领设备中</li><li>2：初始化中</li><li>4：运营中</li><li>7：隔离中</li><li>8：已隔离</li><li>10：解隔离中</li><li>16：故障中</li>
        /// </summary>
        [JsonProperty("DeviceStatus")]
        public ulong? DeviceStatus{ get; set; }

        /// <summary>
        /// 设备操作状态ID，取值：
        /// <li>1：运行中</li><li>2：正在关机</li><li>3：已关机</li><li>5：正在开机</li><li>7：重启中</li><li>9：重装中</li><li>12：绑定EIP</li><li>13：解绑EIP</li><li>14：绑定LB</li><li>15：解绑LB</li><li>19：更换IP中</li><li>20：制作镜像中</li><li>21：制作镜像失败</li>
        /// </summary>
        [JsonProperty("OperateStatus")]
        public ulong? OperateStatus{ get; set; }

        /// <summary>
        /// 操作系统ID，参考接口[查询操作系统信息(DescribeOsInfo)](https://cloud.tencent.com/document/product/386/32902)
        /// </summary>
        [JsonProperty("OsTypeId")]
        public ulong? OsTypeId{ get; set; }

        /// <summary>
        /// RAID类型ID，参考接口[查询机型RAID方式以及系统盘大小(DescribeDeviceClassPartition)](https://cloud.tencent.com/document/product/386/32910)
        /// </summary>
        [JsonProperty("RaidId")]
        public ulong? RaidId{ get; set; }

        /// <summary>
        /// 设备别名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 外网IP
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("LanIp")]
        public string LanIp{ get; set; }

        /// <summary>
        /// 设备交付时间
        /// </summary>
        [JsonProperty("DeliverTime")]
        public string DeliverTime{ get; set; }

        /// <summary>
        /// 设备到期时间
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// 自动续费标识。0: 不自动续费; 1:自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("DeviceClassCode")]
        public string DeviceClassCode{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 计费模式。1: 预付费; 2: 后付费; 3:预付费转后付费中
        /// </summary>
        [JsonProperty("CpmPayMode")]
        public ulong? CpmPayMode{ get; set; }

        /// <summary>
        /// 带外IP
        /// </summary>
        [JsonProperty("DhcpIp")]
        public string DhcpIp{ get; set; }

        /// <summary>
        /// 所在私有网络别名
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 所在子网别名
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 所在私有网络CIDR
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// 所在子网CIDR
        /// </summary>
        [JsonProperty("SubnetCidrBlock")]
        public string SubnetCidrBlock{ get; set; }

        /// <summary>
        /// 标识是否是竞价实例。0: 普通设备; 1: 竞价实例设备
        /// </summary>
        [JsonProperty("IsLuckyDevice")]
        public ulong? IsLuckyDevice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DeviceStatus", this.DeviceStatus);
            this.SetParamSimple(map, prefix + "OperateStatus", this.OperateStatus);
            this.SetParamSimple(map, prefix + "OsTypeId", this.OsTypeId);
            this.SetParamSimple(map, prefix + "RaidId", this.RaidId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "LanIp", this.LanIp);
            this.SetParamSimple(map, prefix + "DeliverTime", this.DeliverTime);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "DeviceClassCode", this.DeviceClassCode);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CpmPayMode", this.CpmPayMode);
            this.SetParamSimple(map, prefix + "DhcpIp", this.DhcpIp);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamSimple(map, prefix + "SubnetCidrBlock", this.SubnetCidrBlock);
            this.SetParamSimple(map, prefix + "IsLuckyDevice", this.IsLuckyDevice);
        }
    }
}

