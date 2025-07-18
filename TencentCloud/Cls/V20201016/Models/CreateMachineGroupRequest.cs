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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMachineGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 机器组名字，不能重复
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 创建机器组类型。取值如下：
        /// - Type：ip，Values中为ip字符串列表创建机器组
        /// - Type：label，Values中为标签字符串列表创建机器组
        /// </summary>
        [JsonProperty("MachineGroupType")]
        public MachineGroupTypeInfo MachineGroupType{ get; set; }

        /// <summary>
        /// 标签描述列表，通过指定该参数可以同时绑定标签到相应的机器组。最大支持10个标签键值对，同一个资源只能绑定到同一个标签键下。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 是否开启机器组自动更新。默认false
        /// </summary>
        [JsonProperty("AutoUpdate")]
        public bool? AutoUpdate{ get; set; }

        /// <summary>
        /// 升级开始时间，建议业务低峰期升级LogListener
        /// </summary>
        [JsonProperty("UpdateStartTime")]
        public string UpdateStartTime{ get; set; }

        /// <summary>
        /// 升级结束时间，建议业务低峰期升级LogListener
        /// </summary>
        [JsonProperty("UpdateEndTime")]
        public string UpdateEndTime{ get; set; }

        /// <summary>
        /// 是否开启服务日志，用于记录因Loglistener 服务自身产生的log，开启后，会创建内部日志集cls_service_logging和日志主题loglistener_status,loglistener_alarm,loglistener_business，不产生计费。默认false
        /// </summary>
        [JsonProperty("ServiceLogging")]
        public bool? ServiceLogging{ get; set; }

        /// <summary>
        /// 机器组中机器离线清理时间。单位：天
        /// </summary>
        [JsonProperty("DelayCleanupTime")]
        public long? DelayCleanupTime{ get; set; }

        /// <summary>
        /// 机器组元数据信息列表
        /// </summary>
        [JsonProperty("MetaTags")]
        public MetaTagInfo[] MetaTags{ get; set; }

        /// <summary>
        /// 系统类型，取值如下：
        /// - 0：Linux （默认值）
        /// - 1：Windows
        /// </summary>
        [JsonProperty("OSType")]
        public ulong? OSType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamObj(map, prefix + "MachineGroupType.", this.MachineGroupType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoUpdate", this.AutoUpdate);
            this.SetParamSimple(map, prefix + "UpdateStartTime", this.UpdateStartTime);
            this.SetParamSimple(map, prefix + "UpdateEndTime", this.UpdateEndTime);
            this.SetParamSimple(map, prefix + "ServiceLogging", this.ServiceLogging);
            this.SetParamSimple(map, prefix + "DelayCleanupTime", this.DelayCleanupTime);
            this.SetParamArrayObj(map, prefix + "MetaTags.", this.MetaTags);
            this.SetParamSimple(map, prefix + "OSType", this.OSType);
        }
    }
}

