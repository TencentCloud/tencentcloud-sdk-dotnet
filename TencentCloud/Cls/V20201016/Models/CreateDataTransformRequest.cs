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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDataTransformRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务类型. 1: 指定主题；2:动态创建。详情请参考[创建加工任务文档](https://cloud.tencent.com/document/product/614/63940)。
        /// </summary>
        [JsonProperty("FuncType")]
        public long? FuncType{ get; set; }

        /// <summary>
        /// 源日志主题
        /// </summary>
        [JsonProperty("SrcTopicId")]
        public string SrcTopicId{ get; set; }

        /// <summary>
        /// 加工任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 加工语句。 当FuncType为2时，EtlContent必须使用[log_auto_output](https://cloud.tencent.com/document/product/614/70733#b3c58797-4825-4807-bef4-68106e25024f) 
        /// 
        /// 其他参考文档：
        /// 
        /// - [创建加工任务](https://cloud.tencent.com/document/product/614/63940) 
        /// -  [函数总览](https://cloud.tencent.com/document/product/614/70395)
        /// </summary>
        [JsonProperty("EtlContent")]
        public string EtlContent{ get; set; }

        /// <summary>
        /// 加工类型。
        /// 1：使用源日志主题中的随机数据，进行加工预览；2：使用用户自定义测试数据，进行加工预览；3：创建真实加工任务。
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 加工任务目的topic_id以及别名,当FuncType=1时，该参数必填，当FuncType=2时，无需填写。
        /// </summary>
        [JsonProperty("DstResources")]
        public DataTransformResouceInfo[] DstResources{ get; set; }

        /// <summary>
        /// 任务启动状态.   默认为1:开启,  2:关闭
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// 用于预览加工结果的测试数据
        /// </summary>
        [JsonProperty("PreviewLogStatistics")]
        public PreviewLogStatistic[] PreviewLogStatistics{ get; set; }

        /// <summary>
        /// 数据加工类型。0：标准加工任务； 1：前置加工任务。前置加工任务将采集的日志处理完成后，再写入日志主题。
        /// </summary>
        [JsonProperty("DataTransformType")]
        public ulong? DataTransformType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FuncType", this.FuncType);
            this.SetParamSimple(map, prefix + "SrcTopicId", this.SrcTopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EtlContent", this.EtlContent);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArrayObj(map, prefix + "DstResources.", this.DstResources);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamArrayObj(map, prefix + "PreviewLogStatistics.", this.PreviewLogStatistics);
            this.SetParamSimple(map, prefix + "DataTransformType", this.DataTransformType);
        }
    }
}

