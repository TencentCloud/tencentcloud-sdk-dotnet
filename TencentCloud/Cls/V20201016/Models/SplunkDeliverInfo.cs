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

    public class SplunkDeliverInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>任务id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>用户id</p>
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// <p>日志主题id</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>任务状态；1.运行中；2:暂停；3：异常</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>启用状态；0:禁用；1:启用</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// <p>创建时间；单位：秒</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间；单位：秒</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// <p>splunk投递任务-目标配置</p>
        /// </summary>
        [JsonProperty("NetInfo")]
        public NetInfo NetInfo{ get; set; }

        /// <summary>
        /// <p>splunk投递任务元信息</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public MetadataInfo Metadata{ get; set; }

        /// <summary>
        /// <p>是否启用服务日志；1:关闭；2:开启</p>
        /// </summary>
        [JsonProperty("HasServiceLog")]
        public long? HasServiceLog{ get; set; }

        /// <summary>
        /// <p>高级配置-数据来源；</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>高级配置-数据来源类型；</p>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>高级配置-Splunk写入的索引</p>
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// <p>高级配置-是否启用索引器；1-不开启；2-开启；</p>
        /// </summary>
        [JsonProperty("IndexAck")]
        public long? IndexAck{ get; set; }

        /// <summary>
        /// <p>高级配置-通道</p>
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// <p>预过滤处理-对写入 Splunk 原始数据进行预过滤处理语句</p>
        /// </summary>
        [JsonProperty("DSLFilter")]
        public string DSLFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "NetInfo.", this.NetInfo);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamSimple(map, prefix + "HasServiceLog", this.HasServiceLog);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "IndexAck", this.IndexAck);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "DSLFilter", this.DSLFilter);
        }
    }
}

