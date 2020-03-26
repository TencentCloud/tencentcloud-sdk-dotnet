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

    public class ReloadDeviceOsRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备的唯一ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 密码。 用户设置的linux root或Windows Administrator密码。密码校验规则: <li> Windows机器密码需12到16位，至少包括三项 `[a-z]`,`[A-Z]`,`[0-9]`和`[()`'`~!@#$%^&*-+=_`|`{}[]:;'<>,.?/]`的特殊符号, 密码不能包含Administrator(不区分大小写); <li> Linux机器密码需8到16位，至少包括两项`[a-z,A-Z]`,`[0-9]`和`[()`'`~!@#$%^&*-+=_`|`{}[]:;'<>,.?/]`的特殊符号
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 操作系统类型ID。通过接口[查询操作系统信息(DescribeOsInfo)](https://cloud.tencent.com/document/api/386/32902)获取操作系统信息
        /// </summary>
        [JsonProperty("OsTypeId")]
        public ulong? OsTypeId{ get; set; }

        /// <summary>
        /// RAID类型ID。通过接口[查询机型RAID方式以及系统盘大小(DescribeDeviceClassPartition)](https://cloud.tencent.com/document/api/386/32910)获取RAID信息
        /// </summary>
        [JsonProperty("RaidId")]
        public ulong? RaidId{ get; set; }

        /// <summary>
        /// 是否格式化数据盘。0: 不格式化（默认值）；1：格式化
        /// </summary>
        [JsonProperty("IsZoning")]
        public ulong? IsZoning{ get; set; }

        /// <summary>
        /// 系统盘根分区大小，默认是10G。系统盘的大小参考接口[查询机型RAID方式以及系统盘大小(DescribeDeviceClassPartition)](https://cloud.tencent.com/document/api/386/32910)
        /// </summary>
        [JsonProperty("SysRootSpace")]
        public ulong? SysRootSpace{ get; set; }

        /// <summary>
        /// 系统盘swap分区或/boot/efi分区的大小。若是uefi启动的机器，分区为/boot/efi ,且此值是默认是2G。普通机器为swap分区，可以不指定此分区。机型是否是uefi启动，参考接口[查询设备型号(DescribeDeviceClass)](https://cloud.tencent.com/document/api/386/32911)
        /// </summary>
        [JsonProperty("SysSwaporuefiSpace")]
        public ulong? SysSwaporuefiSpace{ get; set; }

        /// <summary>
        /// /usr/local分区大小
        /// </summary>
        [JsonProperty("SysUsrlocalSpace")]
        public ulong? SysUsrlocalSpace{ get; set; }

        /// <summary>
        /// 重装到新的私有网络的ID。如果改变VPC子网，则要求与SubnetId同时传参，否则可不填
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 重装到新的子网的ID。如果改变VPC子网，则要求与VpcId同时传参，否则可不填
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 重装指定IP地址
        /// </summary>
        [JsonProperty("LanIp")]
        public string LanIp{ get; set; }

        /// <summary>
        /// 指定是否开启超线程。 0：关闭超线程；1：开启超线程（默认值）
        /// </summary>
        [JsonProperty("HyperThreading")]
        public ulong? HyperThreading{ get; set; }

        /// <summary>
        /// 自定义镜像ID。传此字段则用自定义镜像重装
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 指定数据盘的文件系统格式，当前支持 EXT4和XFS选项， 默认为EXT4。 参数适用于数据盘和Linux， 且在IsZoning为1时生效
        /// </summary>
        [JsonProperty("FileSystem")]
        public string FileSystem{ get; set; }

        /// <summary>
        /// 是否安装安全Agent，取值：1(安装) 0(不安装)，默认取值0
        /// </summary>
        [JsonProperty("NeedSecurityAgent")]
        public ulong? NeedSecurityAgent{ get; set; }

        /// <summary>
        /// 是否安装监控Agent，取值：1(安装) 0(不安装)，默认取值0
        /// </summary>
        [JsonProperty("NeedMonitorAgent")]
        public ulong? NeedMonitorAgent{ get; set; }

        /// <summary>
        /// 是否安装EMR Agent，取值：1(安装) 0(不安装)，默认取值0
        /// </summary>
        [JsonProperty("NeedEMRAgent")]
        public ulong? NeedEMRAgent{ get; set; }

        /// <summary>
        /// 是否安装EMR软件包，取值：1(安装) 0(不安装)，默认取值0
        /// </summary>
        [JsonProperty("NeedEMRSoftware")]
        public ulong? NeedEMRSoftware{ get; set; }

        /// <summary>
        /// 是否保留安全组配置，取值：1(保留) 0(不保留)，默认取值0
        /// </summary>
        [JsonProperty("ReserveSgConfig")]
        public ulong? ReserveSgConfig{ get; set; }

        /// <summary>
        /// /data分区大小，可不填。除root、swap、usr/local的剩余空间会自动分配到data分区
        /// </summary>
        [JsonProperty("SysDataSpace")]
        public ulong? SysDataSpace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "OsTypeId", this.OsTypeId);
            this.SetParamSimple(map, prefix + "RaidId", this.RaidId);
            this.SetParamSimple(map, prefix + "IsZoning", this.IsZoning);
            this.SetParamSimple(map, prefix + "SysRootSpace", this.SysRootSpace);
            this.SetParamSimple(map, prefix + "SysSwaporuefiSpace", this.SysSwaporuefiSpace);
            this.SetParamSimple(map, prefix + "SysUsrlocalSpace", this.SysUsrlocalSpace);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "LanIp", this.LanIp);
            this.SetParamSimple(map, prefix + "HyperThreading", this.HyperThreading);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "FileSystem", this.FileSystem);
            this.SetParamSimple(map, prefix + "NeedSecurityAgent", this.NeedSecurityAgent);
            this.SetParamSimple(map, prefix + "NeedMonitorAgent", this.NeedMonitorAgent);
            this.SetParamSimple(map, prefix + "NeedEMRAgent", this.NeedEMRAgent);
            this.SetParamSimple(map, prefix + "NeedEMRSoftware", this.NeedEMRSoftware);
            this.SetParamSimple(map, prefix + "ReserveSgConfig", this.ReserveSgConfig);
            this.SetParamSimple(map, prefix + "SysDataSpace", this.SysDataSpace);
        }
    }
}

