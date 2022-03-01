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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JvmMonitorData : AbstractModel
    {
        
        /// <summary>
        /// 堆内存监控图,三条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeapMemory")]
        public MemoryPicture HeapMemory{ get; set; }

        /// <summary>
        /// 非堆内存监控图,三条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NonHeapMemory")]
        public MemoryPicture NonHeapMemory{ get; set; }

        /// <summary>
        /// 伊甸园区监控图,三条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EdenSpace")]
        public MemoryPicture EdenSpace{ get; set; }

        /// <summary>
        /// 幸存者区监控图,三条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SurvivorSpace")]
        public MemoryPicture SurvivorSpace{ get; set; }

        /// <summary>
        /// 老年代监控图,三条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldSpace")]
        public MemoryPicture OldSpace{ get; set; }

        /// <summary>
        /// 元空间监控图,三条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaSpace")]
        public MemoryPicture MetaSpace{ get; set; }

        /// <summary>
        /// 线程监控图,三条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThreadPicture")]
        public ThreadPicture ThreadPicture{ get; set; }

        /// <summary>
        /// youngGC增量监控图,一条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YoungGC")]
        public CurvePoint[] YoungGC{ get; set; }

        /// <summary>
        /// fullGC增量监控图,一条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FullGC")]
        public CurvePoint[] FullGC{ get; set; }

        /// <summary>
        /// cpu使用率,一条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuUsage")]
        public CurvePoint[] CpuUsage{ get; set; }

        /// <summary>
        /// 加载类数,一条线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassCount")]
        public CurvePoint[] ClassCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HeapMemory.", this.HeapMemory);
            this.SetParamObj(map, prefix + "NonHeapMemory.", this.NonHeapMemory);
            this.SetParamObj(map, prefix + "EdenSpace.", this.EdenSpace);
            this.SetParamObj(map, prefix + "SurvivorSpace.", this.SurvivorSpace);
            this.SetParamObj(map, prefix + "OldSpace.", this.OldSpace);
            this.SetParamObj(map, prefix + "MetaSpace.", this.MetaSpace);
            this.SetParamObj(map, prefix + "ThreadPicture.", this.ThreadPicture);
            this.SetParamArrayObj(map, prefix + "YoungGC.", this.YoungGC);
            this.SetParamArrayObj(map, prefix + "FullGC.", this.FullGC);
            this.SetParamArrayObj(map, prefix + "CpuUsage.", this.CpuUsage);
            this.SetParamArrayObj(map, prefix + "ClassCount.", this.ClassCount);
        }
    }
}

