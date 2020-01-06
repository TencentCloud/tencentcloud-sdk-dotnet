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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvDataCpm : AbstractModel
    {
        
        /// <summary>
        /// 黑石可用区名称列表。如ap-guangzhou-bls-1, 可通过黑石接口[DescribeRegions]( https://cloud.tencent.com/document/api/386/33564)接口获取。不是Batch可用区名称。目前仅支持一个可用区名称。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 购买的机型ID。通过黑石接口[DescribeDeviceClass]( https://cloud.tencent.com/document/api/386/32911)查询设备型号，获取机型信息。
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// 购买时长单位，取值：m(月)。
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 购买时长。
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// RAID类型ID。通过黑石接口[DescribeDeviceClassPartition]( https://cloud.tencent.com/document/api/386/32910)查询机型RAID方式以及系统盘大小，获取RAID信息。
        /// </summary>
        [JsonProperty("RaidId")]
        public long? RaidId{ get; set; }

        /// <summary>
        /// 部署服务器的操作系统ID。通过批量计算接口DescribeCpmOsInfo查询操作系统信息。
        /// </summary>
        [JsonProperty("OsTypeId")]
        public long? OsTypeId{ get; set; }

        /// <summary>
        /// 黑石VPC列表，目前仅支持一个VPC。
        /// </summary>
        [JsonProperty("VirtualPrivateClouds")]
        public CpmVirtualPrivateCloud[] VirtualPrivateClouds{ get; set; }

        /// <summary>
        /// 是否安装安全Agent，取值：1(安装) 0(不安装)，默认取值0。
        /// </summary>
        [JsonProperty("NeedSecurityAgent")]
        public long? NeedSecurityAgent{ get; set; }

        /// <summary>
        /// 是否安装监控Agent，取值：1(安装) 0(不安装)，默认取值0。
        /// </summary>
        [JsonProperty("NeedMonitorAgent")]
        public long? NeedMonitorAgent{ get; set; }

        /// <summary>
        /// 自动续费标志位，取值：1(自动续费) 0(不自动续费)，默认取值0。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 数据盘是否格式化，取值：1(格式化) 0(不格式化)，默认取值为1。
        /// </summary>
        [JsonProperty("IsZoning")]
        public long? IsZoning{ get; set; }

        /// <summary>
        /// 指定数据盘的文件系统格式，当前支持 ext4和xfs选项， 默认为ext4。 参数适用于数据盘和Linux， 且在IsZoning为1时生效。
        /// </summary>
        [JsonProperty("FileSystem")]
        public string FileSystem{ get; set; }

        /// <summary>
        /// 设置Linux root或Windows Administrator的密码。若不设置此参数，默认情况下会随机生成密码，并以站内信方式通知到用户。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 是否分配弹性公网IP，取值：1(分配) 0(不分配)，默认取值0。
        /// </summary>
        [JsonProperty("ApplyEip")]
        public long? ApplyEip{ get; set; }

        /// <summary>
        /// 弹性公网IP计费模式，取值：flow(按流量计费) bandwidth(按带宽计费)，默认取值flow。
        /// </summary>
        [JsonProperty("EipPayMode")]
        public string EipPayMode{ get; set; }

        /// <summary>
        /// 弹性公网IP带宽限制，单位Mb。
        /// </summary>
        [JsonProperty("EipBandwidth")]
        public long? EipBandwidth{ get; set; }

        /// <summary>
        /// 自定义镜像ID，取值生效时用自定义镜像部署物理机。
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 系统盘根分区大小，单位为G，默认取值10G。通过黑石接口[DescribeDeviceClassPartition]( https://cloud.tencent.com/document/api/386/32910)查询机型RAID方式以及系统盘大小，获取根分区信息。
        /// </summary>
        [JsonProperty("SysRootSpace")]
        public long? SysRootSpace{ get; set; }

        /// <summary>
        /// /data分区大小，单位为G。如果系统盘还有剩余大小，会分配给/data分区。（特殊情况：如果剩余空间不足10G，并且没有指定/data分区，则剩余空间会分配给Root分区）。
        /// </summary>
        [JsonProperty("SysDataSpace")]
        public long? SysDataSpace{ get; set; }

        /// <summary>
        /// 是否开启超线程，取值：1(开启) 0(关闭)，默认取值1。
        /// </summary>
        [JsonProperty("HyperThreading")]
        public long? HyperThreading{ get; set; }

        /// <summary>
        /// 指定的内网IP列表，不指定时自动分配。
        /// </summary>
        [JsonProperty("LanIps")]
        public string[] LanIps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "RaidId", this.RaidId);
            this.SetParamSimple(map, prefix + "OsTypeId", this.OsTypeId);
            this.SetParamArrayObj(map, prefix + "VirtualPrivateClouds.", this.VirtualPrivateClouds);
            this.SetParamSimple(map, prefix + "NeedSecurityAgent", this.NeedSecurityAgent);
            this.SetParamSimple(map, prefix + "NeedMonitorAgent", this.NeedMonitorAgent);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "IsZoning", this.IsZoning);
            this.SetParamSimple(map, prefix + "FileSystem", this.FileSystem);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "ApplyEip", this.ApplyEip);
            this.SetParamSimple(map, prefix + "EipPayMode", this.EipPayMode);
            this.SetParamSimple(map, prefix + "EipBandwidth", this.EipBandwidth);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "SysRootSpace", this.SysRootSpace);
            this.SetParamSimple(map, prefix + "SysDataSpace", this.SysDataSpace);
            this.SetParamSimple(map, prefix + "HyperThreading", this.HyperThreading);
            this.SetParamArraySimple(map, prefix + "LanIps.", this.LanIps);
        }
    }
}

