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

    public class BuyDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区ID。通过接口[查询地域以及可用区(DescribeRegions)](https://cloud.tencent.com/document/api/386/33564)获取可用区信息
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 部署服务器的操作系统ID。通过接口[查询操作系统信息(DescribeOsInfo)](https://cloud.tencent.com/document/product/386/32902)获取操作系统信息
        /// </summary>
        [JsonProperty("OsTypeId")]
        public ulong? OsTypeId{ get; set; }

        /// <summary>
        /// RAID类型ID。通过接口[查询机型RAID方式以及系统盘大小(DescribeDeviceClassPartition)](https://cloud.tencent.com/document/api/386/32910)获取RAID信息
        /// </summary>
        [JsonProperty("RaidId")]
        public ulong? RaidId{ get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [JsonProperty("GoodsCount")]
        public ulong? GoodsCount{ get; set; }

        /// <summary>
        /// 购买至私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 购买至子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 购买的机型ID。通过接口[查询设备型号(DescribeDeviceClass)](https://cloud.tencent.com/document/api/386/32911)获取机型信息
        /// </summary>
        [JsonProperty("DeviceClassCode")]
        public string DeviceClassCode{ get; set; }

        /// <summary>
        /// 购买时长单位，取值：M(月) D(天)
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 购买时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

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
        /// 是否分配弹性公网IP，取值：1(分配) 0(不分配)，默认取值0
        /// </summary>
        [JsonProperty("ApplyEip")]
        public ulong? ApplyEip{ get; set; }

        /// <summary>
        /// 弹性公网IP计费模式，取值：Flow(按流量计费) Bandwidth(按带宽计费)，默认取值Flow
        /// </summary>
        [JsonProperty("EipPayMode")]
        public string EipPayMode{ get; set; }

        /// <summary>
        /// 弹性公网IP带宽限制，单位Mb
        /// </summary>
        [JsonProperty("EipBandwidth")]
        public ulong? EipBandwidth{ get; set; }

        /// <summary>
        /// 数据盘是否格式化，取值：1(格式化) 0(不格式化)，默认取值为1
        /// </summary>
        [JsonProperty("IsZoning")]
        public ulong? IsZoning{ get; set; }

        /// <summary>
        /// 物理机计费模式，取值：1(预付费) 2(后付费)，默认取值为1
        /// </summary>
        [JsonProperty("CpmPayMode")]
        public ulong? CpmPayMode{ get; set; }

        /// <summary>
        /// 自定义镜像ID，取值生效时用自定义镜像部署物理机
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 设置Linux root或Windows Administrator的密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 自动续费标志位，取值：1(自动续费) 0(不自动续费)，默认取值0
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 系统盘根分区大小，单位为G，默认取值10G。通过接口[查询机型RAID方式以及系统盘大小(DescribeDeviceClassPartition)](https://cloud.tencent.com/document/api/386/32910)获取根分区信息
        /// </summary>
        [JsonProperty("SysRootSpace")]
        public ulong? SysRootSpace{ get; set; }

        /// <summary>
        /// 系统盘swap分区或/boot/efi分区的大小，单位为G。若是uefi启动的机器，分区为/boot/efi，且此值是默认是2G。 普通机器为swap分区，可以不指定此分区。 机型是否是uefi启动，参见接口[查询设备型号(DescribeDeviceClass)](https://cloud.tencent.com/document/api/386/32911)
        /// </summary>
        [JsonProperty("SysSwaporuefiSpace")]
        public ulong? SysSwaporuefiSpace{ get; set; }

        /// <summary>
        /// /usr/local分区大小，单位为G
        /// </summary>
        [JsonProperty("SysUsrlocalSpace")]
        public ulong? SysUsrlocalSpace{ get; set; }

        /// <summary>
        /// /data分区大小，单位为G。如果系统盘还有剩余大小，会分配给/data分区。（特殊情况：如果剩余空间不足10G，并且没有指定/data分区，则剩余空间会分配给Root分区）
        /// </summary>
        [JsonProperty("SysDataSpace")]
        public ulong? SysDataSpace{ get; set; }

        /// <summary>
        /// 是否开启超线程，取值：1(开启) 0(关闭)，默认取值1
        /// </summary>
        [JsonProperty("HyperThreading")]
        public ulong? HyperThreading{ get; set; }

        /// <summary>
        /// 指定的内网IP列表，不指定时自动分配
        /// </summary>
        [JsonProperty("LanIps")]
        public string[] LanIps{ get; set; }

        /// <summary>
        /// 设备名称列表
        /// </summary>
        [JsonProperty("Aliases")]
        public string[] Aliases{ get; set; }

        /// <summary>
        /// CPU型号ID，自定义机型需要传入，取值：
        /// <br/><li>1: E5-2620v3 (6核) * 2</li><li>2: E5-2680v4 (14核) * 2</li><li>3: E5-2670v3 (12核) * 2</li><li>4: E5-2620v4 (8核) * 2</li><li>5: 4110 (8核) * 2</li><li>6: 6133 (20核) * 2</li><br/>
        /// </summary>
        [JsonProperty("CpuId")]
        public ulong? CpuId{ get; set; }

        /// <summary>
        /// 是否有RAID卡，取值：1(有) 0(无)，自定义机型需要传入
        /// </summary>
        [JsonProperty("ContainRaidCard")]
        public ulong? ContainRaidCard{ get; set; }

        /// <summary>
        /// 内存大小，单位为G，自定义机型需要传入。取值参考接口[查询自定义机型部件信息(DescribeHardwareSpecification)](https://cloud.tencent.com/document/api/386/33565)返回值
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// 系统盘ID，自定义机型需要传入。取值参考接口[查询自定义机型部件信息(DescribeHardwareSpecification)](https://cloud.tencent.com/document/api/386/33565)返回值
        /// </summary>
        [JsonProperty("SystemDiskTypeId")]
        public ulong? SystemDiskTypeId{ get; set; }

        /// <summary>
        /// 系统盘数量，自定义机型需要传入。取值参考接口[查询自定义机型部件信息(DescribeHardwareSpecification)](https://cloud.tencent.com/document/api/386/33565)返回值
        /// </summary>
        [JsonProperty("SystemDiskCount")]
        public ulong? SystemDiskCount{ get; set; }

        /// <summary>
        /// 数据盘ID，自定义机型需要传入。取值参考接口[查询自定义机型部件信息(DescribeHardwareSpecification)](https://cloud.tencent.com/document/api/386/33565)返回值
        /// </summary>
        [JsonProperty("DataDiskTypeId")]
        public ulong? DataDiskTypeId{ get; set; }

        /// <summary>
        /// 数据盘数量，自定义机型需要传入。取值参考接口[查询自定义机型部件信息(DescribeHardwareSpecification)](https://cloud.tencent.com/document/api/386/33565)返回值
        /// </summary>
        [JsonProperty("DataDiskCount")]
        public ulong? DataDiskCount{ get; set; }

        /// <summary>
        /// 绑定的标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 指定数据盘的文件系统格式，当前支持 EXT4和XFS选项， 默认为EXT4。 参数适用于数据盘和Linux， 且在IsZoning为1时生效
        /// </summary>
        [JsonProperty("FileSystem")]
        public string FileSystem{ get; set; }

        /// <summary>
        /// 此参数是为了防止重复发货。如果两次调用传入相同的BuySession，只会发货一次。 不要以设备别名作为BuySession，这样只会第一次购买成功。参数长度为128位，合法字符为大小字母，数字，下划线，横线。
        /// </summary>
        [JsonProperty("BuySession")]
        public string BuySession{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "OsTypeId", this.OsTypeId);
            this.SetParamSimple(map, prefix + "RaidId", this.RaidId);
            this.SetParamSimple(map, prefix + "GoodsCount", this.GoodsCount);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DeviceClassCode", this.DeviceClassCode);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "NeedSecurityAgent", this.NeedSecurityAgent);
            this.SetParamSimple(map, prefix + "NeedMonitorAgent", this.NeedMonitorAgent);
            this.SetParamSimple(map, prefix + "NeedEMRAgent", this.NeedEMRAgent);
            this.SetParamSimple(map, prefix + "NeedEMRSoftware", this.NeedEMRSoftware);
            this.SetParamSimple(map, prefix + "ApplyEip", this.ApplyEip);
            this.SetParamSimple(map, prefix + "EipPayMode", this.EipPayMode);
            this.SetParamSimple(map, prefix + "EipBandwidth", this.EipBandwidth);
            this.SetParamSimple(map, prefix + "IsZoning", this.IsZoning);
            this.SetParamSimple(map, prefix + "CpmPayMode", this.CpmPayMode);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "SysRootSpace", this.SysRootSpace);
            this.SetParamSimple(map, prefix + "SysSwaporuefiSpace", this.SysSwaporuefiSpace);
            this.SetParamSimple(map, prefix + "SysUsrlocalSpace", this.SysUsrlocalSpace);
            this.SetParamSimple(map, prefix + "SysDataSpace", this.SysDataSpace);
            this.SetParamSimple(map, prefix + "HyperThreading", this.HyperThreading);
            this.SetParamArraySimple(map, prefix + "LanIps.", this.LanIps);
            this.SetParamArraySimple(map, prefix + "Aliases.", this.Aliases);
            this.SetParamSimple(map, prefix + "CpuId", this.CpuId);
            this.SetParamSimple(map, prefix + "ContainRaidCard", this.ContainRaidCard);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "SystemDiskTypeId", this.SystemDiskTypeId);
            this.SetParamSimple(map, prefix + "SystemDiskCount", this.SystemDiskCount);
            this.SetParamSimple(map, prefix + "DataDiskTypeId", this.DataDiskTypeId);
            this.SetParamSimple(map, prefix + "DataDiskCount", this.DataDiskCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "FileSystem", this.FileSystem);
            this.SetParamSimple(map, prefix + "BuySession", this.BuySession);
        }
    }
}

