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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SessionDeviceDetail : AbstractModel
    {
        
        /// <summary>
        /// 设备类型：field或remote
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 起始点位时间，单位：秒
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 结束点位时间，单位：秒
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 码率，单位：kbps
        /// </summary>
        [JsonProperty("Rate")]
        public long?[] Rate{ get; set; }

        /// <summary>
        /// 帧率
        /// </summary>
        [JsonProperty("Fps")]
        public long?[] Fps{ get; set; }

        /// <summary>
        /// 丢包率，单位：%
        /// </summary>
        [JsonProperty("Lost")]
        public float?[] Lost{ get; set; }

        /// <summary>
        /// 网络时延，单位：ms
        /// </summary>
        [JsonProperty("NetworkLatency")]
        public long?[] NetworkLatency{ get; set; }

        /// <summary>
        /// 视频时延，单位：ms
        /// </summary>
        [JsonProperty("VideoLatency")]
        public long?[] VideoLatency{ get; set; }

        /// <summary>
        /// CPU使用率，单位：%
        /// </summary>
        [JsonProperty("CpuUsed")]
        public float?[] CpuUsed{ get; set; }

        /// <summary>
        /// 内存使用率，单位：%
        /// </summary>
        [JsonProperty("MemUsed")]
        public float?[] MemUsed{ get; set; }

        /// <summary>
        /// 时间偏移量，单位：秒
        /// </summary>
        [JsonProperty("TimeOffset")]
        public ulong?[] TimeOffset{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// sdk版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ver")]
        public string Ver{ get; set; }

        /// <summary>
        /// 模式(p2p/server)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SdkMode")]
        public string SdkMode{ get; set; }

        /// <summary>
        /// 解码耗时，单位：ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DecodeCost")]
        public long?[] DecodeCost{ get; set; }

        /// <summary>
        /// 【已废弃，使用RenderCost】
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenderConst")]
        [System.Obsolete]
        public long?[] RenderConst{ get; set; }

        /// <summary>
        /// 卡顿k100
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("K100")]
        public float?[] K100{ get; set; }

        /// <summary>
        /// 卡顿k150
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("K150")]
        public float?[] K150{ get; set; }

        /// <summary>
        /// nack请求数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NACK")]
        public long?[] NACK{ get; set; }

        /// <summary>
        /// 服务端调控码率,单位：kbps
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BitRateEstimate")]
        public long?[] BitRateEstimate{ get; set; }

        /// <summary>
        /// 宽度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 高度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 编码耗时，单位：ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncodeCost")]
        public long?[] EncodeCost{ get; set; }

        /// <summary>
        /// 采集耗时，单位：ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CaptureCost")]
        public long?[] CaptureCost{ get; set; }

        /// <summary>
        /// 渲染耗时，单位：ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenderCost")]
        public long?[] RenderCost{ get; set; }

        /// <summary>
        /// 配置宽度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigWidth")]
        public long? ConfigWidth{ get; set; }

        /// <summary>
        /// 配置高度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigHeight")]
        public long? ConfigHeight{ get; set; }

        /// <summary>
        /// 平均帧间隔
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameDelta")]
        public long?[] FrameDelta{ get; set; }

        /// <summary>
        /// 最大帧间隔
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxFrameDelta")]
        public long?[] MaxFrameDelta{ get; set; }

        /// <summary>
        /// 总码率评估,单位：kbps
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalBitrateEstimate")]
        public long?[] TotalBitrateEstimate{ get; set; }

        /// <summary>
        /// 帧间隔大于100ms的卡顿时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Lag100Duration")]
        public long?[] Lag100Duration{ get; set; }

        /// <summary>
        /// 帧间隔大于150ms的卡顿时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Lag150Duration")]
        public long?[] Lag150Duration{ get; set; }

        /// <summary>
        /// 是否开启多网：0 单网，1 多网
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiMode")]
        public long? MultiMode{ get; set; }

        /// <summary>
        /// 多网卡信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiNet")]
        public MultiNet[] MultiNet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamArraySimple(map, prefix + "Rate.", this.Rate);
            this.SetParamArraySimple(map, prefix + "Fps.", this.Fps);
            this.SetParamArraySimple(map, prefix + "Lost.", this.Lost);
            this.SetParamArraySimple(map, prefix + "NetworkLatency.", this.NetworkLatency);
            this.SetParamArraySimple(map, prefix + "VideoLatency.", this.VideoLatency);
            this.SetParamArraySimple(map, prefix + "CpuUsed.", this.CpuUsed);
            this.SetParamArraySimple(map, prefix + "MemUsed.", this.MemUsed);
            this.SetParamArraySimple(map, prefix + "TimeOffset.", this.TimeOffset);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Ver", this.Ver);
            this.SetParamSimple(map, prefix + "SdkMode", this.SdkMode);
            this.SetParamArraySimple(map, prefix + "DecodeCost.", this.DecodeCost);
            this.SetParamArraySimple(map, prefix + "RenderConst.", this.RenderConst);
            this.SetParamArraySimple(map, prefix + "K100.", this.K100);
            this.SetParamArraySimple(map, prefix + "K150.", this.K150);
            this.SetParamArraySimple(map, prefix + "NACK.", this.NACK);
            this.SetParamArraySimple(map, prefix + "BitRateEstimate.", this.BitRateEstimate);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamArraySimple(map, prefix + "EncodeCost.", this.EncodeCost);
            this.SetParamArraySimple(map, prefix + "CaptureCost.", this.CaptureCost);
            this.SetParamArraySimple(map, prefix + "RenderCost.", this.RenderCost);
            this.SetParamSimple(map, prefix + "ConfigWidth", this.ConfigWidth);
            this.SetParamSimple(map, prefix + "ConfigHeight", this.ConfigHeight);
            this.SetParamArraySimple(map, prefix + "FrameDelta.", this.FrameDelta);
            this.SetParamArraySimple(map, prefix + "MaxFrameDelta.", this.MaxFrameDelta);
            this.SetParamArraySimple(map, prefix + "TotalBitrateEstimate.", this.TotalBitrateEstimate);
            this.SetParamArraySimple(map, prefix + "Lag100Duration.", this.Lag100Duration);
            this.SetParamArraySimple(map, prefix + "Lag150Duration.", this.Lag150Duration);
            this.SetParamSimple(map, prefix + "MultiMode", this.MultiMode);
            this.SetParamArrayObj(map, prefix + "MultiNet.", this.MultiNet);
        }
    }
}

