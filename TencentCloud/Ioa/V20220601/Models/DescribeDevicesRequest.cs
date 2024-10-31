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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件参数（字段含义请参考接口返回值）
        /// 
        /// - Mid, 类型String，支持操作：【eq，like，ilike】，支持排序
        /// - Name, 类型String，支持操作：【eq，like，ilike】，支持排序
        /// - Itime, 类型String，支持操作：【eq，like，ilike】，支持排序
        /// - UserName, 类型String，支持操作：【eq，like，ilike】，支持排序
        /// - MacAddr, 类型String，支持操作：【eq，like，ilike】，支持排序
        /// - UserId, 类型String，支持操作：【eq，like，ilike】，支持排序
        /// - Ip, 类型String，支持操作：【eq，like，ilike】，支持排序
        /// - Tags，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - LocalIpList，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - SerialNum，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - Version，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - StrVersion，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - RtpStatus，类型String，支持操作：【eq，like，ilike】，**不支持排序**
        /// - HostName，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - IoaUserName，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - GroupName，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - CriticalVulListCount，**类型Int**，支持操作：【eq】，**不支持排序**
        /// - RiskCount，**类型Int**，支持操作：【eq】，**不支持排序**
        /// - VulVersion，类型String，支持操作：【eq，like，ilike】，**不支持排序**
        /// - Virusver，类型String，支持操作：【eq，like，ilike】，**不支持排序**
        /// - SysRepver，类型String，支持操作：【eq，like，ilike】，**不支持排序**
        /// - BaseBoardSn，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - Os，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - ConnActiveTime，类型String，支持操作：【eq，like，ilike】，**不支持排序**
        /// - FirewallStatus，**类型Int**，支持操作：【eq】，**不支持排序**
        /// - ProfileName，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - DomainName，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - SysRepVersion，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - VirusVer，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - Cpu，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - Memory，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - HardDiskSize，类型String，支持操作：【eq，like，ilike】，支持排序
        /// - HardwareChangeCount，**类型Int**，支持操作：【eq】，支持排序
        /// - AccountName，类型String，支持操作：【like.ilike】，支持排序
        /// - AccountGroupName，类型String，支持操作：【like.ilike】，支持排序
        /// - ScreenRecordingPermission，**类型Int**，支持操作：【eq】，支持排序
        /// - DiskAccessPermission，**类型Int**，支持操作：【eq】，支持排序
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 分页参数
        /// - PageNum 从1开始，小于等于0时使用默认参数
        /// - PageSize 最大值5000，最好不超过100
        /// </summary>
        [JsonProperty("Condition")]
        public Condition Condition{ get; set; }

        /// <summary>
        /// 【和GroupIds必须有一个填写】设备分组id（需要和OsType匹配），下面是私有化场景下默认id：
        /// id-名称-操作系统
        /// 1	全网终端	Win
        /// 2	未分组终端	Win
        /// 30000000	服务器	Win
        /// 40000101	全网终端	Linux
        /// 40000102	未分组终端	Linux
        /// 40000103	服务器	Linux
        /// 40000201	全网终端	macOS
        /// 40000202	未分组终端	macOS
        /// 40000203	服务器	macOS
        /// 40000401	全网终端	Android
        /// 40000402	未分组终端	Android
        /// 40000501	全网终端	iOS
        /// 40000502	未分组终端	iOS
        /// 
        /// 
        /// SaaS需要调用分组接口DescribeDeviceChildGroups获取对应分组id
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// 【必填】操作系统类型（0: win，1：linux，2: mac，4：android，5：ios   默认值0），需要和GroupId或者GroupIds匹配
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 在线状态 （2表示在线，0或者1表示离线）
        /// </summary>
        [JsonProperty("OnlineStatus")]
        public long? OnlineStatus{ get; set; }

        /// <summary>
        /// 过滤条件--兼容旧接口,参数同Condition
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段--兼容旧接口,参数同Condition
        /// </summary>
        [JsonProperty("Sort")]
        public Sort Sort{ get; set; }

        /// <summary>
        /// 获取第几页--兼容旧接口,参数同Condition
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// 每页获取数--兼容旧接口,参数同Condition
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 授权状态： 4基础授权 5高级授权
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 【和GroupId必须有一个填写】设备分组id列表（需要和OsType匹配）
        /// </summary>
        [JsonProperty("GroupIds")]
        public long?[] GroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "OnlineStatus", this.OnlineStatus);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
        }
    }
}

