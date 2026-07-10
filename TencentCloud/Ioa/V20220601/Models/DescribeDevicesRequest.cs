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

    public class DescribeDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 管理域实例ID，用于CAM管理域权限分配。若企业未进行管理域的划分，可直接传入根域"1"，此时表示针对当前企业的全部设备和账号进行接口CRUD，具体CRUD的影响范围限制于相应接口的入参。
        /// </summary>
        [JsonProperty("DomainInstanceId")]
        public string DomainInstanceId{ get; set; }

        /// <summary>
        /// <p>过滤条件参数（字段含义请参考接口返回值）</p><ul><li>Mid, 类型String，支持操作：【eq，like，ilike】，支持排序</li><li>Name, 类型String，支持操作：【eq，like，ilike】，支持排序</li><li>Itime, 类型String，支持操作：【eq，like，ilike】，支持排序</li><li>UserName, 类型String，支持操作：【eq，like，ilike】，支持排序</li><li>MacAddr, 类型String，支持操作：【eq，like，ilike】，支持排序</li><li>UserId, 类型String，支持操作：【eq，like，ilike】，支持排序</li><li>Ip, 类型String，支持操作：【eq，like，ilike】，支持排序</li><li>Tags，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>LocalIpList，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>SerialNum，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>Version，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>StrVersion，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>RtpStatus，类型String，支持操作：【eq，like，ilike】，<strong>不支持排序</strong></li><li>HostName，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>IoaUserName，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>GroupName，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>CriticalVulListCount，<strong>类型Int</strong>，支持操作：【eq】，<strong>不支持排序</strong></li><li>RiskCount，<strong>类型Int</strong>，支持操作：【eq】，<strong>不支持排序</strong></li><li>VulVersion，类型String，支持操作：【eq，like，ilike】，<strong>不支持排序</strong></li><li>Virusver，类型String，支持操作：【eq，like，ilike】，<strong>不支持排序</strong></li><li>SysRepver，类型String，支持操作：【eq，like，ilike】，<strong>不支持排序</strong></li><li>BaseBoardSn，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>Os，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>ConnActiveTime，类型String，支持操作：【eq，like，ilike】，<strong>不支持排序</strong></li><li>FirewallStatus，<strong>类型Int</strong>，支持操作：【eq】，<strong>不支持排序</strong></li><li>DomainName，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>SysRepVersion，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>VirusVer，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>Cpu，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>Memory，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>HardDiskSize，类型String，支持操作：【eq，like，ilike】，支持排序</li><li>AccountName，类型String，支持操作：【like.ilike】，支持排序</li><li>AccountGroupName，类型String，支持操作：【like.ilike】，支持排序</li></ul><p>分页参数</p><ul><li>PageNum 从1开始，小于等于0时使用默认参数</li><li>PageSize 最大值5000，最好不超过100</li></ul>
        /// </summary>
        [JsonProperty("Condition")]
        public Condition Condition{ get; set; }

        /// <summary>
        /// <p>【和GroupIds必须有一个填写】设备分组id（需要和OsType匹配），下面是私有化场景下默认id：<br>id-名称-操作系统<br>1    全网终端    Win<br>2    未分组终端    Win<br>30000000    服务器    Win<br>40000101    全网终端    Linux<br>40000102    未分组终端    Linux<br>40000103    服务器    Linux<br>40000201    全网终端    macOS<br>40000202    未分组终端    macOS<br>40000203    服务器    macOS<br>40000401    全网终端    Android<br>40000402    未分组终端    Android<br>40000501    全网终端    iOS<br>40000502    未分组终端    iOS</p><p>SaaS需要调用分组接口DescribeDeviceChildGroups获取对应分组id</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// <p>系统类型（0: win，1：linux，2: mac，4：android，5：ios，-1：全系统（SaaS一体化版本） ； 不传默认为0）(只支持32位)，需要和GroupId或者GroupIds匹配</p>
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// <p>在线状态 （2表示在线，0或者1表示离线）</p>
        /// </summary>
        [JsonProperty("OnlineStatus")]
        public long? OnlineStatus{ get; set; }

        /// <summary>
        /// <p>过滤条件--兼容旧接口,参数同Condition</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>排序字段--兼容旧接口,参数同Condition</p>
        /// </summary>
        [JsonProperty("Sort")]
        public Sort Sort{ get; set; }

        /// <summary>
        /// <p>获取第几页--兼容旧接口,参数同Condition</p>
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// <p>每页获取数--兼容旧接口,参数同Condition</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>授权状态： 4基础授权 5高级授权</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>【和GroupId必须有一个填写】设备分组id列表（需要和OsType匹配）</p>
        /// </summary>
        [JsonProperty("GroupIds")]
        public long?[] GroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainInstanceId", this.DomainInstanceId);
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

