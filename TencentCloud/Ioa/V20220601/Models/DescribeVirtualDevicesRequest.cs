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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVirtualDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 管理域实例ID，用于CAM管理域权限分配。若企业未进行管理域的划分，可直接传入根域"1"，此时表示针对当前企业的全部设备和账号进行接口CRUD，具体CRUD的影响范围限制于相应接口的入参。
        /// </summary>
        [JsonProperty("DomainInstanceId")]
        public string DomainInstanceId{ get; set; }

        /// <summary>
        /// 过滤条件参数（字段含义请参考接口返回值）- Mid, 类型String，支持操作：【eq，like，ilike】，支持排序- Name, 类型String，支持操作：【eq，like，ilike】，支持排序- Itime, 类型String，支持操作：【eq，like，ilike】，支持排序- UserName, 类型String，支持操作：【eq，like，ilike】，支持排序- MacAddr, 类型String，支持操作：【eq，like，ilike】，支持排序- UserId, 类型String，支持操作：【eq，like，ilike】，支持排序- Ip, 类型String，支持操作：【eq，like，ilike】，支持排序- Tags，类型String，支持操作：【eq，like，ilike】，支持排序- LocalIpList，类型String，支持操作：【eq，like，ilike】，支持排序- SerialNum，类型String，支持操作：【eq，like，ilike】，支持排序- Version，类型String，支持操作：【eq，like，ilike】，支持排序- StrVersion，类型String，支持操作：【eq，like，ilike】，支持排序- RtpStatus，类型String，支持操作：【eq，like，ilike】，**不支持排序**- HostName，类型String，支持操作：【eq，like，ilike】，支持排序- IoaUserName，类型String，支持操作：【eq，like，ilike】，支持排序- GroupName，类型String，支持操作：【eq，like，ilike】，支持排序- CriticalVulListCount，**类型Int**，支持操作：【eq】，**不支持排序**- RiskCount，**类型Int**，支持操作：【eq】，**不支持排序**- VulVersion，类型String，支持操作：【eq，like，ilike】，**不支持排序**- Virusver，类型String，支持操作：【eq，like，ilike】，**不支持排序**- SysRepver，类型String，支持操作：【eq，like，ilike】，**不支持排序**- BaseBoardSn，类型String，支持操作：【eq，like，ilike】，支持排序- Os，类型String，支持操作：【eq，like，ilike】，支持排序- ConnActiveTime，类型String，支持操作：【eq，like，ilike】，**不支持排序**- FirewallStatus，**类型Int**，支持操作：【eq】，**不支持排序**- ProfileName，类型String，支持操作：【eq，like，ilike】，支持排序- DomainName，类型String，支持操作：【eq，like，ilike】，支持排序- SysRepVersion，类型String，支持操作：【eq，like，ilike】，支持排序- VirusVer，类型String，支持操作：【eq，like，ilike】，支持排序- Cpu，类型String，支持操作：【eq，like，ilike】，支持排序- Memory，类型String，支持操作：【eq，like，ilike】，支持排序- HardDiskSize，类型String，支持操作：【eq，like，ilike】，支持排序- HardwareChangeCount，**类型Int**，支持操作：【eq】，支持排序- AccountName，类型String，支持操作：【like.ilike】，支持排序- AccountGroupName，类型String，支持操作：【like.ilike】，支持排序- ScreenRecordingPermission，**类型Int**，支持操作：【eq】，支持排序- DiskAccessPermission，**类型Int**，支持操作：【eq】，支持排序分页参数- PageNum 从1开始，小于等于0时使用默认参数- PageSize 最大值5000，最好不超过100
        /// </summary>
        [JsonProperty("Condition")]
        public Condition Condition{ get; set; }

        /// <summary>
        /// 必填，终端自定义分组id
        /// </summary>
        [JsonProperty("DeviceVirtualGroupId")]
        public long? DeviceVirtualGroupId{ get; set; }

        /// <summary>
        /// 必填，系统类型（0: win，1：linux，2: mac，3: win_srv，4：android，5：ios   默认值0）
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 选填，在线状态 （2表示在线，0或者1表示离线）
        /// </summary>
        [JsonProperty("OnlineStatus")]
        public long? OnlineStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainInstanceId", this.DomainInstanceId);
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
            this.SetParamSimple(map, prefix + "DeviceVirtualGroupId", this.DeviceVirtualGroupId);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "OnlineStatus", this.OnlineStatus);
        }
    }
}

