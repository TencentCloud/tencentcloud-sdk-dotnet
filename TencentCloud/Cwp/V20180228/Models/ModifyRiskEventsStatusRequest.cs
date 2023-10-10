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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRiskEventsStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作-0:标记已处理,1:忽略,2:删除记录,3:木马隔离,4:木马恢复隔离,5:木马信任,6:木马取消信任,7:查杀异常进程
        /// </summary>
        [JsonProperty("Operate")]
        public ulong? Operate{ get; set; }

        /// <summary>
        /// 操作事件类型，文件查杀：MALWARE，异常登录：HOST_LOGIN，密码破解：BRUTE_ATTACK，恶意请求：MALICIOUS_REQUEST，高危命令：BASH_EVENT，本地提权：PRIVILEGE_EVENT，反弹shell：REVERSE_SHELL. 异常进程:PROCESS
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// 需要修改的事件id 数组，支持批量
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// 是否更新全部，即是否对所有的事件进行操作，当ids 不为空时，此参数无效
        /// </summary>
        [JsonProperty("UpdateAll")]
        public bool? UpdateAll{ get; set; }

        /// <summary>
        /// 排除的事件id,当操作全部事件时，需要排除这次id
        /// </summary>
        [JsonProperty("ExcludeId")]
        public ulong?[] ExcludeId{ get; set; }

        /// <summary>
        /// 当Operate 是木马隔离时，表示是否要杀进程，其他操作无效
        /// </summary>
        [JsonProperty("KillProcess")]
        public bool? KillProcess{ get; set; }

        /// <summary>
        /// 当RiskType 为异地登录且ids为空时，可以修改所有来源ip的事件的状态
        /// </summary>
        [JsonProperty("Ip")]
        public string[] Ip{ get; set; }

        /// <summary>
        /// 过滤条件。RiskType为 MALWARE时
        /// 1、当RiskType为 MALWARE时：
        /// <li>IpOrAlias - String - 是否必填：否 - 主机ip或别名筛选</li>
        /// <li>FilePath - String - 是否必填：否 - 路径筛选</li>
        /// <li>VirusName - String - 是否必填：否 - 描述筛选</li>
        /// <li>CreateBeginTime - String - 是否必填：否 - 创建时间筛选-开始时间</li>
        /// <li>CreateEndTime - String - 是否必填：否 - 创建时间筛选-结束时间</li>
        /// <li>Status - String - 是否必填：否 - 状态筛选 4待处理,5信任,6已隔离,10隔离中,11恢复隔离中</li>
        /// RiskType 为PROCESS时:
        /// 过滤条件。
        /// <li>IpOrName - String - 是否必填：否 - 主机IP或主机名</li>
        /// <li>VirusName - String - 是否必填：否 - 病毒名</li>
        /// <li>BeginTime - String - 是否必填：否 - 进程启动时间-开始</li>
        /// <li>EndTime - String - 是否必填：否 - 进程启动时间-结束</li>
        /// <li>Status - String - 是否必填：否 - 状态筛选 0待处理；1查杀中;2已查杀3已退出;4已信任</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamSimple(map, prefix + "UpdateAll", this.UpdateAll);
            this.SetParamArraySimple(map, prefix + "ExcludeId.", this.ExcludeId);
            this.SetParamSimple(map, prefix + "KillProcess", this.KillProcess);
            this.SetParamArraySimple(map, prefix + "Ip.", this.Ip);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

