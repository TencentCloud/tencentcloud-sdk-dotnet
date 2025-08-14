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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJvmMonitorRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询的实例ID
        /// 可通过调用[DescribeClusterInstances](https://cloud.tencent.com/document/product/649/36048)查询已导入的实例列表或登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1&tab=instance)进行查询。实例ID例如：ins-6decplwk
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例所属应用ID
        /// 可通过调用[DescribeApplications](https://cloud.tencent.com/document/product/649/36090)查询已经存在的应用列表或登录[控制台](https://console.cloud.tencent.com/tsf/app?rid=1)查看。应用ID例如：application-v378ewna
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 时间粒度,单位:秒
        /// </summary>
        [JsonProperty("TimeGranularity")]
        public long? TimeGranularity{ get; set; }

        /// <summary>
        /// 查询数据起始时间格式(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 查询数据结束时间格式(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonProperty("To")]
        public string To{ get; set; }

        /// <summary>
        /// 查询的监控图列表，以返回值属性名作为入参，可选值：
        /// heapMemory：堆内存监控图；nonHeapMemory：非堆内存监控图；edenSpace：伊甸区监控图；survivorSpace：幸存者区监控图；oldSpace：老年代监控图；metaSpace：元空间监控图；youngGC：youngGC增量监控图；fullGC：fullGC增量监控图；cpuUsage：cpu使用率监控图；classCount：加载类数监控图；threadPicture：线程图
        /// </summary>
        [JsonProperty("RequiredPictures")]
        public string[] RequiredPictures{ get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "TimeGranularity", this.TimeGranularity);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamArraySimple(map, prefix + "RequiredPictures.", this.RequiredPictures);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
        }
    }
}

