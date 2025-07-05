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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateRecordPlanData : AbstractModel
    {
        
        /// <summary>
        /// 上云计划名称，仅支持中文、英文、数字、_、-，长度不超过32个字符，计划名称全局唯一，不能为空，不能重复，不修改名称时，不需要该字段
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// 上云模板ID，不修改模板ID时，不需要该字段
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 上云计划描述，仅支持中文、英文、数字、_、-，长度不超过128个字符， 不修改描述时，不需要该字段
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// 码流类型，default:不指定码流类型，以设备默认推送类型为主， main:主码流，sub:子码流，其他根据设备能力集自定义，长度不能超过32个字节
        /// </summary>
        [JsonProperty("StreamType")]
        public string StreamType{ get; set; }

        /// <summary>
        /// 生命周期，文件生命周期设置，管理文件冷、热存储的时间，不修改生命周期时，不需要该字段
        /// </summary>
        [JsonProperty("LifeCycle")]
        public LifeCycleData LifeCycle{ get; set; }

        /// <summary>
        /// 要新增的设备通道,Json数组，没有新增时，不需要该字段，一次添加通道总数不超过5000个，包括组织目录下的通道数量
        /// </summary>
        [JsonProperty("Add")]
        public ChannelInfo[] Add{ get; set; }

        /// <summary>
        /// 要删除的设备通道，Json数组，内容为要删除的设备通道id，没有删除设备通道时，不需要该字段
        /// </summary>
        [JsonProperty("Del")]
        public string[] Del{ get; set; }

        /// <summary>
        /// 组织目录ID，添加组织目录下所有设备通道，Json数组，可以为空，并且通道总数量不超过5000个（包括Add字段通道数量）
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string[] OrganizationId{ get; set; }

        /// <summary>
        /// 录像补录模式（0:不启用，1:启用）
        /// </summary>
        [JsonProperty("RepairMode")]
        public long? RepairMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamObj(map, prefix + "LifeCycle.", this.LifeCycle);
            this.SetParamArrayObj(map, prefix + "Add.", this.Add);
            this.SetParamArraySimple(map, prefix + "Del.", this.Del);
            this.SetParamArraySimple(map, prefix + "OrganizationId.", this.OrganizationId);
            this.SetParamSimple(map, prefix + "RepairMode", this.RepairMode);
        }
    }
}

